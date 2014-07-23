using NHibernate;
using System;
using System.Windows.Forms;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.CustomEventArgs;

namespace PAK_Command_Editor.SignalsCatalog
{
    public partial class AddVendorForm : Form
    {
        private ISession _dataSession;
        private IRepository<Vendor> _vendorsRepository;

        public event EventHandler<ResultEntityEventArgs> VendorAdded;

        public AddVendorForm(ISession dataSession)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._vendorsRepository = new Repository<Vendor>(this._dataSession);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            Vendor newVendor = new Vendor() {Name = this.txtVendorName.Text};
            this._vendorsRepository.SaveOrUpdate(newVendor);

            if (this.VendorAdded != null)
                this.VendorAdded(this, new ResultEntityEventArgs() {EntityId = newVendor.Id});

            this.Close();
        }

        private void txtVendorName_TextChanged(object sender, EventArgs e)
        {
            this.btnAddVendor.Enabled = !String.IsNullOrEmpty(this.txtVendorName.Text);
        }

        private void AddVendorForm_FormClosing(object sender, FormClosingEventArgs e)
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
