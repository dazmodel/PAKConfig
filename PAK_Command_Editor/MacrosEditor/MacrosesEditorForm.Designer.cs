namespace PAK_Command_Editor.MacrosEditor
{
    partial class MacrosesEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacrosesEditorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.btnAddSignal = new System.Windows.Forms.Button();
            this.cbSelectSignal = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.gvMacros = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveMacros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVendors = new System.Windows.Forms.ComboBox();
            this.lblDeviceModel = new System.Windows.Forms.Label();
            this.cbDeviceModels = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbDeviceModels);
            this.groupBox1.Controls.Add(this.lblDeviceModel);
            this.groupBox1.Controls.Add(this.cbVendors);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblSignal);
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Controls.Add(this.cbSelectSignal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор Сигнала";
            // 
            // lblSignal
            // 
            this.lblSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSignal.AutoSize = true;
            this.lblSignal.Enabled = false;
            this.lblSignal.Location = new System.Drawing.Point(12, 55);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(224, 13);
            this.lblSignal.TabIndex = 2;
            this.lblSignal.Text = "Имя сигнала, связываемого с макросом: ";
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSignal.Enabled = false;
            this.btnAddSignal.Location = new System.Drawing.Point(498, 50);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(45, 23);
            this.btnAddSignal.TabIndex = 1;
            this.btnAddSignal.Text = "+";
            this.btnAddSignal.UseVisualStyleBackColor = true;
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // cbSelectSignal
            // 
            this.cbSelectSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSelectSignal.Enabled = false;
            this.cbSelectSignal.FormattingEnabled = true;
            this.cbSelectSignal.Location = new System.Drawing.Point(242, 52);
            this.cbSelectSignal.Name = "cbSelectSignal";
            this.cbSelectSignal.Size = new System.Drawing.Size(243, 21);
            this.cbSelectSignal.TabIndex = 0;
            this.cbSelectSignal.SelectedIndexChanged += new System.EventHandler(this.cbSelectSignal_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDeleteCommand);
            this.groupBox2.Controls.Add(this.btnAddCommand);
            this.groupBox2.Controls.Add(this.gvMacros);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Макрос для выбранного сигнала";
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(15, 290);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteCommand.TabIndex = 5;
            this.btnDeleteCommand.Text = "Удалить команду";
            this.btnDeleteCommand.UseVisualStyleBackColor = true;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCommand.Location = new System.Drawing.Point(413, 290);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(130, 23);
            this.btnAddCommand.TabIndex = 2;
            this.btnAddCommand.Text = "Добавить команду";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // gvMacros
            // 
            this.gvMacros.AllowUserToAddRows = false;
            this.gvMacros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMacros.Location = new System.Drawing.Point(15, 19);
            this.gvMacros.Name = "gvMacros";
            this.gvMacros.Size = new System.Drawing.Size(528, 265);
            this.gvMacros.TabIndex = 0;
            this.gvMacros.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMacros_RowEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(487, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveMacros
            // 
            this.btnSaveMacros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMacros.Enabled = false;
            this.btnSaveMacros.Location = new System.Drawing.Point(392, 427);
            this.btnSaveMacros.Name = "btnSaveMacros";
            this.btnSaveMacros.Size = new System.Drawing.Size(89, 23);
            this.btnSaveMacros.TabIndex = 4;
            this.btnSaveMacros.Text = "Сохранить...";
            this.btnSaveMacros.UseVisualStyleBackColor = true;
            this.btnSaveMacros.Click += new System.EventHandler(this.btnSaveMacros_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Производитель: ";
            // 
            // cbVendors
            // 
            this.cbVendors.FormattingEnabled = true;
            this.cbVendors.Location = new System.Drawing.Point(110, 22);
            this.cbVendors.Name = "cbVendors";
            this.cbVendors.Size = new System.Drawing.Size(176, 21);
            this.cbVendors.TabIndex = 4;
            this.cbVendors.SelectedIndexChanged += new System.EventHandler(this.cbVendors_SelectedIndexChanged);
            // 
            // lblDeviceModel
            // 
            this.lblDeviceModel.AutoSize = true;
            this.lblDeviceModel.Enabled = false;
            this.lblDeviceModel.Location = new System.Drawing.Point(296, 25);
            this.lblDeviceModel.Name = "lblDeviceModel";
            this.lblDeviceModel.Size = new System.Drawing.Size(52, 13);
            this.lblDeviceModel.TabIndex = 5;
            this.lblDeviceModel.Text = "Модель: ";
            // 
            // cbDeviceModels
            // 
            this.cbDeviceModels.Enabled = false;
            this.cbDeviceModels.FormattingEnabled = true;
            this.cbDeviceModels.Location = new System.Drawing.Point(354, 22);
            this.cbDeviceModels.Name = "cbDeviceModels";
            this.cbDeviceModels.Size = new System.Drawing.Size(189, 21);
            this.cbDeviceModels.TabIndex = 6;
            this.cbDeviceModels.SelectedIndexChanged += new System.EventHandler(this.cbDeviceModels_SelectedIndexChanged);
            // 
            // MacrosesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.btnSaveMacros);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MacrosesEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор Макросов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MacrosesEditorForm_FormClosing);
            this.Shown += new System.EventHandler(this.MacrosesEditorForm_Shown);
            this.ResizeEnd += new System.EventHandler(this.MacrosesEditorForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MacrosesEditorForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMacros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSelectSignal;
        private System.Windows.Forms.Button btnAddSignal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.DataGridView gvMacros;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveMacros;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.ComboBox cbDeviceModels;
        private System.Windows.Forms.Label lblDeviceModel;
        private System.Windows.Forms.ComboBox cbVendors;
        private System.Windows.Forms.Label label2;
    }
}