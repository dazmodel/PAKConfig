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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSignal = new System.Windows.Forms.Button();
            this.cbSelectSignal = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.gvMacros = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveMacros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Controls.Add(this.cbSelectSignal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор Сигнала";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя сигнала, связываемого с макросом: ";
            // 
            // btnAddSignal
            // 
            this.btnAddSignal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddSignal.Location = new System.Drawing.Point(498, 17);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(45, 23);
            this.btnAddSignal.TabIndex = 1;
            this.btnAddSignal.Text = "+";
            this.btnAddSignal.UseVisualStyleBackColor = true;
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // cbSelectSignal
            // 
            this.cbSelectSignal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSelectSignal.FormattingEnabled = true;
            this.cbSelectSignal.Location = new System.Drawing.Point(239, 19);
            this.cbSelectSignal.Name = "cbSelectSignal";
            this.cbSelectSignal.Size = new System.Drawing.Size(253, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Макрос для выбранного сигнала";
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCommand.Location = new System.Drawing.Point(15, 273);
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
            this.btnAddCommand.Location = new System.Drawing.Point(413, 273);
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
            this.gvMacros.Size = new System.Drawing.Size(528, 248);
            this.gvMacros.TabIndex = 0;
            this.gvMacros.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMacros_RowEnter);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(487, 377);
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
            this.btnSaveMacros.Location = new System.Drawing.Point(392, 377);
            this.btnSaveMacros.Name = "btnSaveMacros";
            this.btnSaveMacros.Size = new System.Drawing.Size(89, 23);
            this.btnSaveMacros.TabIndex = 4;
            this.btnSaveMacros.Text = "Сохранить...";
            this.btnSaveMacros.UseVisualStyleBackColor = true;
            this.btnSaveMacros.Click += new System.EventHandler(this.btnSaveMacros_Click);
            // 
            // MacrosesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
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
        private System.Windows.Forms.Label label1;
    }
}