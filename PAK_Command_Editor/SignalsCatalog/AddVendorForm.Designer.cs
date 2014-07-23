namespace PAK_Command_Editor.SignalsCatalog
{
    partial class AddVendorForm
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
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.btnAddVendor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(55, 13);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(217, 20);
            this.txtVendorName.TabIndex = 0;
            this.txtVendorName.TextChanged += new System.EventHandler(this.txtVendorName_TextChanged);
            // 
            // btnAddVendor
            // 
            this.btnAddVendor.Enabled = false;
            this.btnAddVendor.Location = new System.Drawing.Point(116, 50);
            this.btnAddVendor.Name = "btnAddVendor";
            this.btnAddVendor.Size = new System.Drawing.Size(75, 23);
            this.btnAddVendor.TabIndex = 1;
            this.btnAddVendor.Text = "Добавить";
            this.btnAddVendor.UseVisualStyleBackColor = true;
            this.btnAddVendor.Click += new System.EventHandler(this.btnAddVendor_Click);
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
            // AddVendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddVendor);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddVendorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новый производитель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVendorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Button btnAddVendor;
        private System.Windows.Forms.Button btnCancel;
    }
}