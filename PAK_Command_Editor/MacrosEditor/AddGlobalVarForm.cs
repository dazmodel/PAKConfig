using PAK_Command_Editor.CustomEventArgs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PAK_Command_Editor.MacrosEditor
{
    public partial class AddGlobalVarForm : Form
    {
        public AddGlobalVarForm()
        {
            InitializeComponent();
        }

        public event EventHandler<ResultEntityEventArgs> GlobalVarAdded;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGlobalVarAlias_TextChanged(object sender, EventArgs e)
        {
            this.btnAddVar.Enabled = !String.IsNullOrEmpty(this.txtGlobalVarAlias.Text);
        }

        private void AddGlobalVarForm_Load(object sender, EventArgs e)
        {
            this.cbGlobalVarValue.SelectedIndex = 1;
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {                        
            GlobalVariablesStorage.AddByName(this.txtGlobalVarAlias.Text);

            if (this.GlobalVarAdded != null)
                this.GlobalVarAdded(this, new ResultEntityEventArgs() { Params = new List<String>() { this.txtGlobalVarAlias.Text } });

            this.Close();
        }
    }
}
