using NHibernate;
using PAK_Command_Editor.CustomEventArgs;
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
    public partial class AddDelayCommandForm : Form
    {        
        private MacrosesEditorForm _editor;

        public AddDelayCommandForm(MacrosesEditorForm editor)
        {
            InitializeComponent();            
            this._editor = editor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.btnAddDelayCommand.Enabled = !String.IsNullOrEmpty(this.txtDelay.Text);
        }

        private void btnAddDelayCommand_Click(object sender, EventArgs e)
        {
            ResultEntityEventArgs result = new ResultEntityEventArgs();
            result.CommandType = MacrosCommandType.DELAY;
            result.Params = new List<String>() { this.txtDelay.Text };

            this._editor.BindMacroses(result);
            this.Close();
        }
    }
}
