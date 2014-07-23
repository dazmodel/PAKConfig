using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAK_Command_Editor.Settings
{
    public partial class ServiceCommandsForm : Form
    {
        public ServiceCommandsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = (!String.IsNullOrEmpty(this.txtTeachCommand.Text)) &&
                                   (!String.IsNullOrEmpty(this.txtTestCommand.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PAKSettingsManager.Settings.TeachingCommand = this.txtTeachCommand.Text;
            PAKSettingsManager.Settings.TestCommand = this.txtTestCommand.Text;
            PAKSettingsManager.Settings.ReadSignalCommand = this.txtReadSignal.Text;
            PAKSettingsManager.Settings.ReadMacrosCommand = this.txtReadMacros.Text;
            PAKSettingsManager.Settings.WriteSignalCommand = this.txtWriteSignal.Text;
            PAKSettingsManager.Settings.WriteMacrosCommand = this.txtWriteMacros.Text;
            PAKSettingsManager.SaveSettings();
            this.Close();
        }

        private void ServiceCommandsForm_Load(object sender, EventArgs e)
        {
            this.txtTeachCommand.Text = PAKSettingsManager.Settings.TeachingCommand;
            this.txtTestCommand.Text = PAKSettingsManager.Settings.TestCommand;
            this.txtReadSignal.Text = PAKSettingsManager.Settings.ReadSignalCommand;
            this.txtReadMacros.Text = PAKSettingsManager.Settings.ReadMacrosCommand;
            this.txtWriteSignal.Text = PAKSettingsManager.Settings.WriteSignalCommand;
            this.txtWriteMacros.Text = PAKSettingsManager.Settings.WriteMacrosCommand;
        }
    }
}
