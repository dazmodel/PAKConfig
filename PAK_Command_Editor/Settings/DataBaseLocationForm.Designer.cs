namespace PAK_Command_Editor.Settings
{
    partial class DataBaseLocationForm
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
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.txtDataBaseLocation = new System.Windows.Forms.TextBox();
            this.dlgDataBaseLocation = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenDialog);
            this.groupBox1.Controls.Add(this.txtDataBaseLocation);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите расположение ";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(277, 17);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(35, 23);
            this.btnOpenDialog.TabIndex = 1;
            this.btnOpenDialog.Text = "...";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // txtDataBaseLocation
            // 
            this.txtDataBaseLocation.Location = new System.Drawing.Point(6, 19);
            this.txtDataBaseLocation.Name = "txtDataBaseLocation";
            this.txtDataBaseLocation.Size = new System.Drawing.Size(264, 20);
            this.txtDataBaseLocation.TabIndex = 0;
            this.txtDataBaseLocation.TextChanged += new System.EventHandler(this.txtDataBaseLocation_TextChanged);
            // 
            // dlgDataBaseLocation
            // 
            this.dlgDataBaseLocation.DefaultExt = "sqlite";
            this.dlgDataBaseLocation.Filter = "SQLite database|*.sqlite";
            this.dlgDataBaseLocation.RestoreDirectory = true;
            this.dlgDataBaseLocation.Title = "Расположение базы данных";
            this.dlgDataBaseLocation.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgDataBaseLocation_FileOk);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Enabled = false;
            this.btnSaveSettings.Location = new System.Drawing.Point(176, 71);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.Text = "ОК";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DataBaseLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 102);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DataBaseLocationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расположение базы данных";
            this.Load += new System.EventHandler(this.DataBaseLocationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.TextBox txtDataBaseLocation;
        private System.Windows.Forms.OpenFileDialog dlgDataBaseLocation;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnCancel;
    }
}