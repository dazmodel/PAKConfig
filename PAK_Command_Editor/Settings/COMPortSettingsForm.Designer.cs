namespace PAK_Command_Editor.Settings
{
    partial class COMPortSettingsForm
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
            this.cbPortBand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbComPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimeout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbPortBand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbComPortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры COM-порта";
            // 
            // cbPortBand
            // 
            this.cbPortBand.FormattingEnabled = true;
            this.cbPortBand.Location = new System.Drawing.Point(110, 47);
            this.cbPortBand.Name = "cbPortBand";
            this.cbPortBand.Size = new System.Drawing.Size(91, 21);
            this.cbPortBand.TabIndex = 3;
            this.cbPortBand.SelectedValueChanged += new System.EventHandler(this.cb_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Скорость: ";
            // 
            // cbComPortName
            // 
            this.cbComPortName.FormattingEnabled = true;
            this.cbComPortName.Location = new System.Drawing.Point(110, 20);
            this.cbComPortName.Name = "cbComPortName";
            this.cbComPortName.Size = new System.Drawing.Size(91, 21);
            this.cbComPortName.TabIndex = 1;
            this.cbComPortName.SelectedValueChanged += new System.EventHandler(this.cb_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя порта: ";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(64, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(145, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Таймаут (мс): ";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(110, 74);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(91, 20);
            this.txtTimeout.TabIndex = 5;
            // 
            // COMPortSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 166);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "COMPortSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки COM-порта";
            this.Load += new System.EventHandler(this.COMPortSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPortBand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbComPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label3;
    }
}