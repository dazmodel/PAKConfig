namespace PAK_Command_Editor.SignalsCatalog
{
    partial class AddSignalForm
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
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnTestSignal = new System.Windows.Forms.Button();
            this.btnTeach = new System.Windows.Forms.Button();
            this.txtHexCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSignalName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.lblDeviceModel = new System.Windows.Forms.Label();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSignal = new System.Windows.Forms.Button();
            this.btnCancelAdding = new System.Windows.Forms.Button();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddDevice);
            this.groupBox1.Controls.Add(this.btnTestSignal);
            this.groupBox1.Controls.Add(this.btnTeach);
            this.groupBox1.Controls.Add(this.txtHexCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSignalName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDevice);
            this.groupBox1.Controls.Add(this.lblDeviceModel);
            this.groupBox1.Controls.Add(this.cbVendor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры сигнала";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Location = new System.Drawing.Point(296, 49);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(39, 23);
            this.btnAddDevice.TabIndex = 11;
            this.btnAddDevice.Text = "+";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnTestSignal
            // 
            this.btnTestSignal.Enabled = false;
            this.btnTestSignal.Location = new System.Drawing.Point(9, 231);
            this.btnTestSignal.Name = "btnTestSignal";
            this.btnTestSignal.Size = new System.Drawing.Size(86, 23);
            this.btnTestSignal.TabIndex = 9;
            this.btnTestSignal.Text = "Тест";
            this.btnTestSignal.UseVisualStyleBackColor = true;
            this.btnTestSignal.Click += new System.EventHandler(this.btnTestSignal_Click);
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(9, 202);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(86, 23);
            this.btnTeach.TabIndex = 8;
            this.btnTeach.Text = "Обучение";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // txtHexCode
            // 
            this.txtHexCode.Location = new System.Drawing.Point(101, 103);
            this.txtHexCode.Multiline = true;
            this.txtHexCode.Name = "txtHexCode";
            this.txtHexCode.Size = new System.Drawing.Size(234, 151);
            this.txtHexCode.TabIndex = 7;
            this.txtHexCode.TextChanged += new System.EventHandler(this.txtHexCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "HEX-код:";
            // 
            // txtSignalName
            // 
            this.txtSignalName.Location = new System.Drawing.Point(101, 77);
            this.txtSignalName.Name = "txtSignalName";
            this.txtSignalName.Size = new System.Drawing.Size(234, 20);
            this.txtSignalName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя сигнала:";
            // 
            // cbDevice
            // 
            this.cbDevice.Enabled = false;
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(101, 50);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(189, 21);
            this.cbDevice.TabIndex = 3;
            this.cbDevice.SelectedIndexChanged += new System.EventHandler(this.cbDevice_SelectedIndexChanged);
            // 
            // lblDeviceModel
            // 
            this.lblDeviceModel.AutoSize = true;
            this.lblDeviceModel.Enabled = false;
            this.lblDeviceModel.Location = new System.Drawing.Point(6, 54);
            this.lblDeviceModel.Name = "lblDeviceModel";
            this.lblDeviceModel.Size = new System.Drawing.Size(49, 13);
            this.lblDeviceModel.TabIndex = 2;
            this.lblDeviceModel.Text = "Модель:";
            // 
            // cbVendor
            // 
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(101, 23);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(189, 21);
            this.cbVendor.TabIndex = 1;
            this.cbVendor.SelectedIndexChanged += new System.EventHandler(this.cbVendor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производитель:";
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Enabled = false;
            this.btnAddSignal.Location = new System.Drawing.Point(197, 278);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSignal.TabIndex = 1;
            this.btnAddSignal.Text = "Добавить";
            this.btnAddSignal.UseVisualStyleBackColor = true;
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // btnCancelAdding
            // 
            this.btnCancelAdding.Location = new System.Drawing.Point(278, 278);
            this.btnCancelAdding.Name = "btnCancelAdding";
            this.btnCancelAdding.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdding.TabIndex = 2;
            this.btnCancelAdding.Text = "Отмена";
            this.btnCancelAdding.UseVisualStyleBackColor = true;
            this.btnCancelAdding.Click += new System.EventHandler(this.btnCancelAdding_Click);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Location = new System.Drawing.Point(308, 34);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(39, 23);
            this.btnAddVendor.TabIndex = 10;
            this.btnAddVendor.Text = "+";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
            // 
            // AddSignalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 313);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.btnCancelAdding);
            this.Controls.Add(this.btnAddSignal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSignalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового сигнала";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSignalForm_FormClosing);
            this.Load += new System.EventHandler(this.AddSignalForm_Load);
            this.Shown += new System.EventHandler(this.AddSignalForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddSignal;
        private System.Windows.Forms.Button btnCancelAdding;
        private System.Windows.Forms.Button btnTestSignal;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.TextBox txtHexCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSignalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDevice;
        private System.Windows.Forms.Label lblDeviceModel;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnAddVendor;
    }
}