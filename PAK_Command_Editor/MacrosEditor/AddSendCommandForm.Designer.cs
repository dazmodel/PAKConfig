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
            this.lblSignal = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeviceModel = new System.Windows.Forms.ComboBox();
            this.lblDeviceModel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тело команды";
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Enabled = false;
            this.btnAddSignal.Location = new System.Drawing.Point(248, 72);
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
            this.cbSelectTarget.Location = new System.Drawing.Point(107, 19);
            this.cbSelectTarget.Name = "cbSelectTarget";
            this.cbSelectTarget.Size = new System.Drawing.Size(134, 21);
            this.cbSelectTarget.TabIndex = 3;
            this.cbSelectTarget.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Устройство: ";
            // 
            // cbSelectSignal
            // 
            this.cbSelectSignal.Enabled = false;
            this.cbSelectSignal.FormattingEnabled = true;
            this.cbSelectSignal.Location = new System.Drawing.Point(107, 73);
            this.cbSelectSignal.Name = "cbSelectSignal";
            this.cbSelectSignal.Size = new System.Drawing.Size(134, 21);
            this.cbSelectSignal.TabIndex = 1;
            this.cbSelectSignal.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Enabled = false;
            this.lblSignal.Location = new System.Drawing.Point(12, 76);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(49, 13);
            this.lblSignal.TabIndex = 0;
            this.lblSignal.Text = "Сигнал: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(268, 219);
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
            this.btnAddCommand.Location = new System.Drawing.Point(187, 219);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommand.TabIndex = 6;
            this.btnAddCommand.Text = "ОК";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDeviceModel);
            this.groupBox2.Controls.Add(this.lblDeviceModel);
            this.groupBox2.Controls.Add(this.cbVendor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbSelectSignal);
            this.groupBox2.Controls.Add(this.btnAddSignal);
            this.groupBox2.Controls.Add(this.lblSignal);
            this.groupBox2.Location = new System.Drawing.Point(19, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Что отправлять";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSelectTarget);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 52);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Куда отправлять";
            // 
            // cbVendor
            // 
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(107, 19);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(134, 21);
            this.cbVendor.TabIndex = 6;
            this.cbVendor.SelectedIndexChanged += new System.EventHandler(this.cbVendor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Производитель:";
            // 
            // cbDeviceModel
            // 
            this.cbDeviceModel.Enabled = false;
            this.cbDeviceModel.FormattingEnabled = true;
            this.cbDeviceModel.Location = new System.Drawing.Point(107, 46);
            this.cbDeviceModel.Name = "cbDeviceModel";
            this.cbDeviceModel.Size = new System.Drawing.Size(134, 21);
            this.cbDeviceModel.TabIndex = 8;
            this.cbDeviceModel.SelectedIndexChanged += new System.EventHandler(this.cbDeviceModel_SelectedIndexChanged);
            // 
            // lblDeviceModel
            // 
            this.lblDeviceModel.AutoSize = true;
            this.lblDeviceModel.Enabled = false;
            this.lblDeviceModel.Location = new System.Drawing.Point(12, 49);
            this.lblDeviceModel.Name = "lblDeviceModel";
            this.lblDeviceModel.Size = new System.Drawing.Size(49, 13);
            this.lblDeviceModel.TabIndex = 7;
            this.lblDeviceModel.Text = "Модель:";
            // 
            // AddSendCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 253);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSignal;
        private System.Windows.Forms.ComboBox cbSelectTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectSignal;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbDeviceModel;
        private System.Windows.Forms.Label lblDeviceModel;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.Label label3;
    }
}