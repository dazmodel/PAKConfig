namespace PAK_Command_Editor.MacrosEditor
{
    partial class AddSetResetCommandForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddGlobalVar = new System.Windows.Forms.Button();
            this.cbGlobalVars = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddGlobalVar);
            this.groupBox1.Controls.Add(this.cbGlobalVars);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Глобальная переменная";
            // 
            // btnAddGlobalVar
            // 
            this.btnAddGlobalVar.Location = new System.Drawing.Point(223, 19);
            this.btnAddGlobalVar.Name = "btnAddGlobalVar";
            this.btnAddGlobalVar.Size = new System.Drawing.Size(31, 23);
            this.btnAddGlobalVar.TabIndex = 1;
            this.btnAddGlobalVar.Text = "+";
            this.btnAddGlobalVar.UseVisualStyleBackColor = true;
            this.btnAddGlobalVar.Click += new System.EventHandler(this.btnAddGlobalVar_Click);
            // 
            // cbGlobalVars
            // 
            this.cbGlobalVars.FormattingEnabled = true;
            this.cbGlobalVars.Location = new System.Drawing.Point(7, 20);
            this.cbGlobalVars.Name = "cbGlobalVars";
            this.cbGlobalVars.Size = new System.Drawing.Size(210, 21);
            this.cbGlobalVars.TabIndex = 0;
            this.cbGlobalVars.SelectedIndexChanged += new System.EventHandler(this.cbGlobalVars_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Location = new System.Drawing.Point(115, 71);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommand.TabIndex = 2;
            this.btnAddCommand.Text = "ОК";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // AddSetResetCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 106);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddSetResetCommandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddSetResetCommandForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddGlobalVar;
        private System.Windows.Forms.ComboBox cbGlobalVars;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCommand;

    }
}