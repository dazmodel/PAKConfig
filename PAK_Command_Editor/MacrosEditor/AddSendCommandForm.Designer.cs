namespace PAK_Command_Editor.MacrosEditor
{
    partial class AddSendCommandForm
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
            this.btnAddSignal = new System.Windows.Forms.Button();
            this.cbSelectTarget = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectSignal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Controls.Add(this.cbSelectTarget);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSelectSignal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тело команды";
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Location = new System.Drawing.Point(291, 14);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(34, 23);
            this.btnAddSignal.TabIndex = 4;
            this.btnAddSignal.Text = "+";
            this.btnAddSignal.UseVisualStyleBackColor = true;
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // cbSelectTarget
            // 
            this.cbSelectTarget.FormattingEnabled = true;
            this.cbSelectTarget.Location = new System.Drawing.Point(150, 43);
            this.cbSelectTarget.Name = "cbSelectTarget";
            this.cbSelectTarget.Size = new System.Drawing.Size(134, 21);
            this.cbSelectTarget.TabIndex = 3;
            this.cbSelectTarget.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Куда отправить (устр-во):";
            // 
            // cbSelectSignal
            // 
            this.cbSelectSignal.FormattingEnabled = true;
            this.cbSelectSignal.Location = new System.Drawing.Point(150, 16);
            this.cbSelectSignal.Name = "cbSelectSignal";
            this.cbSelectSignal.Size = new System.Drawing.Size(134, 21);
            this.cbSelectSignal.TabIndex = 1;
            this.cbSelectSignal.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что отправить (сигнал):";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Location = new System.Drawing.Point(198, 99);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommand.TabIndex = 6;
            this.btnAddCommand.Text = "ОК";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // AddSendCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 132);
            this.Controls.Add(this.btnAddCommand);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "AddSendCommandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SEND";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSendCommandForm_FormClosing);
            this.Load += new System.EventHandler(this.AddSendCommandForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSignal;
        private System.Windows.Forms.ComboBox cbSelectTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectSignal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCommand;
    }
}