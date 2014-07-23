using NHibernate;
using PAK_Command_Editor.CustomEventArgs;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.SignalsCatalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAK_Command_Editor.MacrosEditor
{
    public partial class AddSendCommandForm : Form
    {
        private ISession _dataSession;
        private IRepository<Signal> _signalRepo;
        private IRepository<PredefinedGlobalVar> _pgvRepo;
        private static readonly String SELECT_TEXT = "Выберите...";
        private MacrosesEditorForm _editor;

        public AddSendCommandForm(MacrosesEditorForm editor)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._signalRepo = new Repository<Signal>(this._dataSession);
            this._pgvRepo = new Repository<PredefinedGlobalVar>(this._dataSession);
            this._editor = editor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSignal_Click(object sender, EventArgs e)
        {
            AddSignalForm addSignal = new AddSignalForm();
            addSignal.SignalAdded += addSignal_SignalAdded;
            addSignal.ShowDialog();
        }

        void addSignal_SignalAdded(object sender, CustomEventArgs.ResultEntityEventArgs e)
        {
            this.BindSignals();
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            ResultEntityEventArgs commandArgs = new ResultEntityEventArgs();
            commandArgs.CommandType = MacrosCommandType.SEND;
            commandArgs.Params = new List<String>() { (this.cbSelectSignal.SelectedItem as Signal).Id.ToString(), this.cbSelectTarget.SelectedItem.ToString() };
            this._editor.BindMacroses(commandArgs);

            this.Close();
        }

        private void AddSendCommandForm_Load(object sender, EventArgs e)
        {
            this.BindSignals();
            this.BindDestinations();            
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddCommand.Enabled = (this.cbSelectSignal.SelectedIndex > 0) && (this.cbSelectTarget.SelectedIndex > 0);
        }

        #region Utilities

        private void BindSignals()
        {
            this.cbSelectSignal.DisplayMember = "Name";
            this.cbSelectSignal.ValueMember = "Id";

            this.cbSelectSignal.Items.Clear();

            this.cbSelectSignal.Items.Add(new { Name = SELECT_TEXT, Id = -1 });
            this.cbSelectSignal.Items.AddRange(this._signalRepo.GetAll().ToArray());

            this.cbSelectSignal.SelectedIndex = 0;
        }

        private void BindDestinations()
        {
            this.cbSelectTarget.Items.Clear();

            this.cbSelectTarget.Items.Add(SELECT_TEXT);
            this.cbSelectTarget.Items.AddRange(this._pgvRepo.GetAll().Select(x => x.Alias).ToArray());

            this.cbSelectTarget.SelectedIndex = 0;
        }

        #endregion  

        private void AddSendCommandForm_FormClosing(object sender, FormClosingEventArgs e)
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
