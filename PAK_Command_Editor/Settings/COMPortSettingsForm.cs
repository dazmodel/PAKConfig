using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAK_Command_Editor.Settings
{
    public partial class COMPortSettingsForm : Form
    {
        private static readonly String SELECT_TEXT = "Выберите...";

        public COMPortSettingsForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void COMPortSettingsForm_Load(object sender, EventArgs e)
        {
            this.BindPortsNames();
            this.BindPortBand();
            this.txtTimeout.Text = PAKSettingsManager.Settings.COMReadTimeout.ToString();
        }

        #region Utilities

        private void BindPortsNames()
        {
            this.cbComPortName.Items.Clear();
            this.cbComPortName.Items.Add(SELECT_TEXT);
            String[] portsNames = SerialPort.GetPortNames();

            if (portsNames.Length > 0)
            {
                Array.Sort(portsNames);
                this.cbComPortName.Items.AddRange(portsNames);
            }
            
            this.cbComPortName.SelectedItem = PAKSettingsManager.Settings.COMPortName;

            if (this.cbComPortName.SelectedItem == null)
            {
                this.cbComPortName.SelectedIndex = 0;
            }
        }

        private void BindPortBand()
        {
            this.cbPortBand.Items.Clear();
            this.cbPortBand.Items.Add(SELECT_TEXT);

            this.cbPortBand.Items.Add(300);
            this.cbPortBand.Items.Add(600);
            this.cbPortBand.Items.Add(1200);
            this.cbPortBand.Items.Add(2400);
            this.cbPortBand.Items.Add(9600);
            this.cbPortBand.Items.Add(14400);
            this.cbPortBand.Items.Add(19200);
            this.cbPortBand.Items.Add(38400);
            this.cbPortBand.Items.Add(57600);
            this.cbPortBand.Items.Add(115200);

            this.cbPortBand.SelectedItem = PAKSettingsManager.Settings.COMPortBandwidth;

            if (this.cbPortBand.SelectedItem == null)
            {
                this.cbPortBand.SelectedIndex = 0;
            }
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            PAKSettingsManager.Settings.COMPortName = this.cbComPortName.SelectedItem.ToString();
            PAKSettingsManager.Settings.COMPortBandwidth = Convert.ToInt32(this.cbPortBand.SelectedItem);
            PAKSettingsManager.Settings.COMReadTimeout = Convert.ToInt32(this.txtTimeout.Text);
            PAKSettingsManager.SaveSettings();
            this.Close();
        }

        private void cb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.btnSave.Enabled = (this.cbComPortName.SelectedIndex > 0) && (this.cbPortBand.SelectedIndex > 0);
        }
    }
}
