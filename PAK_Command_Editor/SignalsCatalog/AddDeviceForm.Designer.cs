namespace PAK_Command_Editor.SignalsCatalog
{
    partial class AddDeviceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(55, 13);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(217, 20);
            this.txtDeviceName.TabIndex = 0;
            this.txtDeviceName.TextChanged += new System.EventHandler(this.txtDeviceName_TextChanged);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Location = new System.Drawing.Point(116, 50);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(75, 23);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "Добавить";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 50);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новое устройство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDeviceForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnCancel;
    }
}