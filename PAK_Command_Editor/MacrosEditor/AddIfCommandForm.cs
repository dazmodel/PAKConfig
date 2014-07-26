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

namespace PAK_Command_Editor.MacrosEditor
{
    public partial class AddIfCommandForm : Form
    {
        private MacrosesEditorForm _editor;
        private static readonly String SELECT_TEXT = "Выберите...";

        public AddIfCommandForm(MacrosesEditorForm editor)
        {
            InitializeComponent();
            this._editor = editor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGlobalVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAddCommand.Enabled = this.cbGlobalVars.SelectedIndex > 0;
        }

        private void btnAddGlobalVar_Click(object sender, EventArgs e)
        {
            AddGlobalVarForm addGlobalVarForm = new AddGlobalVarForm();
            addGlobalVarForm.GlobalVarAdded += addGlobalVarForm_GlobalVarAdded;
            addGlobalVarForm.ShowDialog();
        }

        void addGlobalVarForm_GlobalVarAdded(object sender, ResultEntityEventArgs e)
        {
            this.BindGlobalVars();
            this.cbGlobalVars.SelectedIndex = 0;
        }

        private void AddIfCommandForm_Load(object sender, EventArgs e)
        {
            this.BindGlobalVars();
            this.cbGlobalVars.SelectedIndex = 0;
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            ResultEntityEventArgs commandArgs = new ResultEntityEventArgs();
            commandArgs.CommandType = MacrosCommandType.IF;
            commandArgs.Params = new List<String>() { (this.cbGlobalVars.SelectedItem as GlobalVariable).Alias };

            this._editor.BindMacroses(commandArgs);

            this.Close();
        }

        #region Utilities

        private void BindGlobalVars()
        {
            this.cbGlobalVars.DisplayMember = "Alias";
            this.cbGlobalVars.ValueMember = "HexCode";

            this.cbGlobalVars.Items.Clear();
            this.cbGlobalVars.Items.Add(new { Alias = SELECT_TEXT, HexCode = "-1" });
            this.cbGlobalVars.Items.AddRange(GlobalVariablesStorage.GlobalVars.Where(x => x.CanReceiveSignals == false).ToArray());
        }

        #endregion                
    }
}
