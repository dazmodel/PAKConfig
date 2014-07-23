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
    public partial class DataBaseLocationForm : Form
    {
        public DataBaseLocationForm()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            this.dlgDataBaseLocation.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dlgDataBaseLocation_FileOk(object sender, CancelEventArgs e)
        {
            this.txtDataBaseLocation.Text = this.dlgDataBaseLocation.FileName;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            PAKSettingsManager.Settings.DataBaseLocation = this.txtDataBaseLocation.Text;
            PAKSettingsManager.SaveSettings();
            this.Close();
        }

        private void DataBaseLocationForm_Load(object sender, EventArgs e)
        {
            this.txtDataBaseLocation.Text = PAKSettingsManager.Settings.DataBaseLocation;
        }

        private void txtDataBaseLocation_TextChanged(object sender, EventArgs e)
        {
            this.btnSaveSettings.Enabled = !String.IsNullOrEmpty(this.txtDataBaseLocation.Text);
        }
    }
}
