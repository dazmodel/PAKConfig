using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.CustomEventArgs;

namespace PAK_Command_Editor.SignalsCatalog
{
    public partial class AddDeviceForm : Form
    {
        private ISession _dataSession;
        private Int32 _vendorId;
        private IRepository<Vendor> _vendorsRepository;
        private IRepository<Device> _devicesRepository; 

        public event EventHandler<ResultEntityEventArgs> DeviceAdded;

        public AddDeviceForm(Int32 vendorId)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._vendorsRepository = new Repository<Vendor>(this._dataSession);
            this._devicesRepository = new Repository<Device>(this._dataSession);
            this._vendorId = vendorId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeviceName_TextChanged(object sender, EventArgs e)
        {
            this.btnAddDevice.Enabled = !String.IsNullOrEmpty(this.txtDeviceName.Text);
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            Vendor parentVendor = this._vendorsRepository.Get(x => x.Id == this._vendorId).SingleOrDefault();
            Device newDevice = new Device() {Name = this.txtDeviceName.Text};
            parentVendor.AddDevice(newDevice);

            using(ITransaction tx = this._dataSession.BeginTransaction())
            {
                this._devicesRepository.SaveOrUpdate(newDevice);
                tx.Commit();
            }
            
            if (this.DeviceAdded != null)
                this.DeviceAdded(this, new ResultEntityEventArgs() {EntityId = newDevice.Id});

            this.Close();
        }

        private void AddDeviceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._dataSession == null) return;

            try
            {
                if (this._dataSession.Transaction.IsActive)
                    this._dataSession.Transaction.Commit();
            }
            catch (Exception)
            {
                if (this._dataSession.Transaction.IsActive)
                    this._dataSession.Transaction.Rollback();
            }
            finally
            {
                this._dataSession.Close();
                this._dataSession.Dispose();
            }
        }
    }
}
