using NHibernate;
using PAK_Command_Editor.CustomEventArgs;
using PAK_Command_Editor.Entities;
using PAK_Command_Editor.Repository;
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
    public partial class SelectCommandTypeForm : Form
    {
        private static readonly String SELECT_TEXT = "Выберите...";
        private ISession _dataSession;
        private IRepository<MacrosCommand> _commandsRepo;
        private MacrosesEditorForm _editor;

        public EventHandler<ResultEntityEventArgs> CommandAdded;

        public SelectCommandTypeForm(MacrosesEditorForm editor)
        {
            InitializeComponent();
            this._dataSession = PAKDataSessionFactory.GetSession();
            this._commandsRepo = new Repository<MacrosCommand>(this._dataSession);
            this._editor = editor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectCommandTypeForm_Load(object sender, EventArgs e)
        {
            this.cbCommandType.DisplayMember = "Alias";
            this.cbCommandType.ValueMember = "Id";

            this.cbCommandType.Items.Clear();
            this.cbCommandType.Items.Add(new { Alias = SELECT_TEXT, Id = -1 });
            this.cbCommandType.Items.AddRange(this._commandsRepo.GetAll().ToArray());

            this.cbCommandType.SelectedIndex = 0;
        }

        private void btnSetCommandType_Click(object sender, EventArgs e)
        {
            MacrosCommandType commandType = (MacrosCommandType)Enum.Parse(typeof(MacrosCommandType), (this.cbCommandType.SelectedItem as MacrosCommand).Alias);
            switch (commandType)
            {
                case MacrosCommandType.DELAY:
                    AddDelayCommandForm addDelay = new AddDelayCommandForm(this._editor);
                    addDelay.ShowDialog();
                    break;
                case MacrosCommandType.SET:
                    AddSetResetCommandForm setForm = new AddSetResetCommandForm(this._editor, MacrosCommandType.SET);
                    setForm.ShowDialog();
                    break;
                case MacrosCommandType.RESET:
                    AddSetResetCommandForm resetForm = new AddSetResetCommandForm(this._editor, MacrosCommandType.RESET);
                    resetForm.ShowDialog();
                    break;
                case MacrosCommandType.SEND:
                    AddSendCommandForm sendForm = new AddSendCommandForm(this._editor);
                    sendForm.ShowDialog();
                    break;
                case MacrosCommandType.IF:
                    AddIfCommandForm ifForm = new AddIfCommandForm(this._editor);
                    ifForm.ShowDialog();
                    break;
            }

            this.Close();
        }

        private void cbCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnSetCommandType.Enabled = this.cbCommandType.SelectedIndex > 0;
        }

        private void SelectCommandTypeForm_FormClosing(object sender, FormClosingEventArgs e)
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
