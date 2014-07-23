namespace PAK_Command_Editor.MacrosEditor
{
    partial class AddDelayCommandForm
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
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.btnAddDelayCommand = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDelay);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Время задержки (мс)";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(7, 20);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(132, 20);
            this.txtDelay.TabIndex = 0;
            this.txtDelay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddDelayCommand
            // 
            this.btnAddDelayCommand.Enabled = false;
            this.btnAddDelayCommand.Location = new System.Drawing.Point(12, 74);
            this.btnAddDelayCommand.Name = "btnAddDelayCommand";
            this.btnAddDelayCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAddDelayCommand.TabIndex = 1;
            this.btnAddDelayCommand.Text = "ОК";
            this.btnAddDelayCommand.UseVisualStyleBackColor = true;
            this.btnAddDelayCommand.Click += new System.EventHandler(this.btnAddDelayCommand_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddDelayCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 102);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDelayCommand);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddDelayCommandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DELAY";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Button btnAddDelayCommand;
        private System.Windows.Forms.Button btnCancel;
    }
}