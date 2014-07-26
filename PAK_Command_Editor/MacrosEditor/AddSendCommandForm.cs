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
        private IRepository<Vendor> _vendorsRepo;
        private IRepository<Device> _devsRepo;        
        private IRepository<Signal> _signalRepo;
        private IRepository<GlobalVariable> _pgvRepo;
        private static readonly String SELECT_TEXT = "Выберите...";
        private MacrosesEditorForm _editor;

        private Vendor _currentVendor;
        private Device _currentDevice;

        public AddSendCommandForm(MacrosesEditorForm editor)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._vendorsRepo = new Repository<Vendor>(this._dataSession);
            this._devsRepo = new Repository<Device>(this._dataSession);
            this._signalRepo = new Repository<Signal>(this._dataSession);
            this._pgvRepo = new Repository<GlobalVariable>(this._dataSession);
            this._editor = editor;
        }

        #region AddSendCommandForm Event Handlers

        private void AddSendCommandForm_Load(object sender, EventArgs e)
        {
            this.ConfigureControls();
            this.BindVendors();
            this.cbVendor.SelectedIndex = 0;

            this.BindDestinations();
        }

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

        #endregion

        #region Buttons Event Handlers

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

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            ResultEntityEventArgs commandArgs = new ResultEntityEventArgs();
            commandArgs.CommandType = MacrosCommandType.SEND;
            commandArgs.Params = new List<String>() { (this.cbSelectSignal.SelectedItem as Signal).HexCodeHash, this.cbSelectTarget.SelectedItem.ToString() };
            this._editor.BindMacroses(commandArgs);

            this.Close();
        }  

        #endregion

        #region ComboBoxes Event Handlers

        private void cbVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean enabled = this.cbVendor.SelectedIndex > 0;

            this.lblDeviceModel.Enabled =
                this.cbDeviceModel.Enabled = enabled;

            this._currentVendor = this.cbVendor.SelectedItem as Vendor;

            if (enabled)
            {
                this.BindDevices();
                this.cbDeviceModel.SelectedIndex = 0;
            }
        }

        private void cbDeviceModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean enabled = this.cbDeviceModel.SelectedIndex > 0;

            this.lblSignal.Enabled =
                this.cbSelectSignal.Enabled = this.btnAddSignal.Enabled = enabled;

            this._currentDevice = this.cbDeviceModel.SelectedItem as Device;

            if (enabled)
            {
                this.BindSignals();
                this.cbSelectSignal.SelectedIndex = 0;
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddCommand.Enabled = (this.cbSelectSignal.SelectedIndex > 0) && (this.cbSelectTarget.SelectedIndex > 0);
        }

        #endregion

        #region Related Forms Event Handlers

        void addSignal_SignalAdded(object sender, CustomEventArgs.ResultEntityEventArgs e)
        {
            this.BindSignals();
        } 

        #endregion        

        #region Utilities

        private void ConfigureControls()
        {
            this.cbVendor.DisplayMember = "Name";
            this.cbVendor.ValueMember = "Id";

            this.cbDeviceModel.DisplayMember = "Name";
            this.cbDeviceModel.ValueMember = "Id";

            this.cbSelectSignal.DisplayMember = "Name";
            this.cbSelectSignal.ValueMember = "Id";
        }

        private void BindVendors()
        {
            this.cbVendor.Items.Clear();
            this.cbVendor.Items.Add(new { Name = SELECT_TEXT, Id = -1 });
            this.cbVendor.Items.AddRange(this._vendorsRepo.GetAll().ToArray());
        }

        private void BindDevices()
        {
            this.cbDeviceModel.Items.Clear();
            this.cbDeviceModel.Items.Add(new { Name = SELECT_TEXT, Id = -1 });
            Device[] devices = this._devsRepo.Get(x => x.Vendor.Id == this._currentVendor.Id).ToArray();
            this.cbDeviceModel.Items.AddRange(devices);
        }        

        private void BindSignals()
        {
            this.cbSelectSignal.Items.Clear();

            this.cbSelectSignal.Items.Add(new { Name = SELECT_TEXT, Id = -1 });
            this.cbSelectSignal.Items.AddRange(this._signalRepo.Get(x => x.Device.Id == this._currentDevice.Id).ToArray());

            this.cbSelectSignal.SelectedIndex = 0;
        }

        private void BindDestinations()
        {
            this.cbSelectTarget.Items.Clear();

            this.cbSelectTarget.Items.Add(SELECT_TEXT);
            this.cbSelectTarget.Items.AddRange(this._pgvRepo.Get(x => x.CanReceiveSignals).Select(x => x.Alias).ToArray());

            this.cbSelectTarget.SelectedIndex = 0;
        }

        #endregion        
    }
}
