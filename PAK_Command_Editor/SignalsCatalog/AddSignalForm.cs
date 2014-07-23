using System.Linq;
using NHibernate;
using PAK_Command_Editor.CustomEventArgs;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
using System;
using System.Windows.Forms;
using PAK_Command_Editor.HardwareInteractionModule;
using PAK_Command_Editor.Settings;
using System.Collections.Generic;

namespace PAK_Command_Editor.SignalsCatalog
{
    public partial class AddSignalForm : Form
    {
        private ISession _dataSession;
        private IRepository<Vendor> _vendorsRepo;
        private IRepository<Signal> _signalsRepo;
        private IRepository<Device> _devsRepo;
        private PAKHardwareInteractionModule _hwModule;
        private static readonly String SELECT_TEXT = "Выберите...";
        private static readonly String NEW_SIGNAL_ADDED_MSG = "Сигнал {0} успешно добавлен.";
        private static readonly String COM_MSG_PATTERN = "{0} {1}\r\n";
        private static readonly String ERROR = "Ошибка";
        private Vendor _currentVendor;
        private Device _currentDevice;
        
        public Form ParentFormRef { get; set; }
        public event EventHandler<ResultEntityEventArgs> SignalAdded;

        public AddSignalForm()
        {
            InitializeComponent();
            this._hwModule = new PAKHardwareInteractionModule();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._vendorsRepo = new Repository<Vendor>(this._dataSession);
            this._signalsRepo = new Repository<Signal>(this._dataSession);
            this._devsRepo = new Repository<Device>(this._dataSession);
        }

        #region AddSignalForm Event Handlers

        private void AddSignalForm_Load(object sender, EventArgs e)
        {
            this.ConfigureControls();
            this.BindVendors();
            this.cbVendor.SelectedIndex = 0;
        }

        private void AddSignalForm_Shown(object sender, EventArgs e)
        {
            this._hwModule.DataReceivedFromPort += _hwModule_DataReceivedFromPort;
        }        

        private void AddSignalForm_FormClosing(object sender, FormClosingEventArgs e)
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

            this._hwModule.Dispose();
        }

        #endregion

        #region Buttons Event Handlers

        private void btnCancelAdding_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestSignal_Click(object sender, EventArgs e)
        {
            String msgToSend = String.Format(COM_MSG_PATTERN, PAKSettingsManager.Settings.TestCommand,
                                             this.txtHexCode.Text);
            String result = this._hwModule.SendData(msgToSend);
            MessageBox.Show(result);
        }

        private void btnTeach_Click(object sender, EventArgs e)
        {
            String result = this._hwModule.SendDataAndWait(PAKSettingsManager.Settings.TeachingCommand);
            MessageBox.Show(result);
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            AddVendorForm addVendorForm = new AddVendorForm(this._dataSession);
            addVendorForm.MdiParent = this.ParentFormRef;
            addVendorForm.VendorAdded += addVendorForm_VendorAdded;
            addVendorForm.Show();
        }        
        
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm(this._currentVendor.Id)
                                              {MdiParent = this.ParentFormRef};
            addDeviceForm.DeviceAdded += addDeviceForm_DeviceAdded;
            addDeviceForm.ShowDialog();
        }

        private void btnAddSignal_Click(object sender, EventArgs e)
        {
            Signal newSignal = new Signal();
            newSignal.Name = this.txtSignalName.Text;
            newSignal.HexCode = this.txtHexCode.Text;
            newSignal.HexCodeHash = newSignal.ComputeMD5Hash(newSignal.HexCode);
            this._currentDevice.AddSignal(newSignal);

            this._signalsRepo.SaveOrUpdate(newSignal);

            MessageBox.Show(String.Format(NEW_SIGNAL_ADDED_MSG, newSignal.Name));

            if (this.SignalAdded != null)
                this.SignalAdded(this, new ResultEntityEventArgs() { EntityId = newSignal.Id });
        } 

        #endregion

        #region Check Boxes Event Handlers

        private void cbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean enabled = this.cbVendor.SelectedIndex > 0;

            this.lblDeviceModel.Enabled =
                this.cbDevice.Enabled = this.btnAddDevice.Enabled = enabled;

            this._currentVendor = this.cbVendor.SelectedItem as Vendor;

            if (enabled)
            {
                this.BindDevices();
                this.cbDevice.SelectedIndex = 0;
            }
        }

        private void cbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._currentDevice = this.cbDevice.SelectedItem as Device;
        } 

        #endregion

        #region Text Boxes Event Handlers

        private void txtHexCode_TextChanged(object sender, EventArgs e)
        {
            this.btnAddSignal.Enabled = (!String.IsNullOrEmpty(this.txtSignalName.Text)) &&
                                        (!String.IsNullOrEmpty(this.txtHexCode.Text));

            this.btnTestSignal.Enabled = !String.IsNullOrEmpty(this.txtHexCode.Text);
        }  

        #endregion

        #region Signal-related Event Handlers

        void addDeviceForm_DeviceAdded(object sender, ResultEntityEventArgs e)
        {
            this.BindDevices();
        }

        void addVendorForm_VendorAdded(object sender, ResultEntityEventArgs e)
        {
            this.BindVendors();
        }

        void _hwModule_DataReceivedFromPort(object sender, ComPortDataEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion           

        #region Utilities

        private void ConfigureControls()
        {
            this.cbVendor.DisplayMember = "Name";
            this.cbVendor.ValueMember = "Id";

            this.cbDevice.DisplayMember = "Name";
            this.cbDevice.ValueMember = "Id";
        }

        private void BindVendors()
        {
            this.cbVendor.Items.Clear();
            this.cbVendor.Items.Add( new { Name = SELECT_TEXT, Id = -1 });
            this.cbVendor.Items.AddRange(this._vendorsRepo.GetAll().ToArray());
        }

        private void BindDevices()
        {
            this.cbDevice.Items.Clear();
            this.cbDevice.Items.Add(new { Name = SELECT_TEXT, Id = -1 });
            Device[] devices = this._devsRepo.Get(x => x.Vendor.Id == this._currentVendor.Id).ToArray();
            this.cbDevice.Items.AddRange(devices);
        }

        #endregion                        
    }
}
