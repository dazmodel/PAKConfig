using NHibernate;
using PAK_Command_Editor.CustomEventArgs;
using PAK_Command_Editor.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAK_Command_Editor.Repository;

namespace PAK_Command_Editor.SignalsCatalog
{
    public partial class EditSignalForm : Form
    {
        private Signal _signalToEdit;
        private ISession _dataSession;
        private IRepository<Signal> _signalRepo;
        private static readonly String TITLE = "Изменение сигнала {0}";

        public event EventHandler<ResultEntityEventArgs> SignalChanged;

        public EditSignalForm(Int32 signalToEditId)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._signalRepo=new Repository<Signal>(this._dataSession);
            this._signalToEdit = this._signalRepo.Get(x => x.Id == signalToEditId).SingleOrDefault();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = (!String.IsNullOrEmpty(this.txtSignalName.Text)) &&
                                   (!String.IsNullOrEmpty(this.txtHexCode.Text));

        }

        private void EditSignalForm_Load(object sender, EventArgs e)
        {
            this.Text = String.Format(TITLE, this._signalToEdit.Name);
            this.txtSignalName.Text = this._signalToEdit.Name;
            this.txtHexCode.Text = this._signalToEdit.HexCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._signalToEdit.Name = this.txtSignalName.Text;
            this._signalToEdit.HexCode = this.txtHexCode.Text;

            using(ITransaction transaction =this._dataSession.BeginTransaction())
            {
                this._signalRepo.SaveOrUpdate(this._signalToEdit);
                transaction.Commit();
            }

            if (this.SignalChanged != null)
                this.SignalChanged(this, new ResultEntityEventArgs() {EntityId = this._signalToEdit.Id});

            this.Close();
        }

        private void EditSignalForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtHexCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                txtHexCode.SelectAll();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
