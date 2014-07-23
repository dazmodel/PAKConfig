namespace PAK_Command_Editor.SignalsCatalog
{
    partial class SignalsCatalogViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignalsCatalogViewForm));
            this.gbAvailableSignals = new System.Windows.Forms.GroupBox();
            this.btnEditSignal = new System.Windows.Forms.Button();
            this.btnDeleteSignal = new System.Windows.Forms.Button();
            this.btnNewSignal = new System.Windows.Forms.Button();
            this.gvAvailableSignals = new System.Windows.Forms.DataGridView();
            this.gbAvailableSignals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAvailableSignals)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAvailableSignals
            // 
            this.gbAvailableSignals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAvailableSignals.Controls.Add(this.btnEditSignal);
            this.gbAvailableSignals.Controls.Add(this.btnDeleteSignal);
            this.gbAvailableSignals.Controls.Add(this.btnNewSignal);
            this.gbAvailableSignals.Controls.Add(this.gvAvailableSignals);
            this.gbAvailableSignals.Location = new System.Drawing.Point(12, 12);
            this.gbAvailableSignals.Name = "gbAvailableSignals";
            this.gbAvailableSignals.Size = new System.Drawing.Size(560, 388);
            this.gbAvailableSignals.TabIndex = 0;
            this.gbAvailableSignals.TabStop = false;
            this.gbAvailableSignals.Text = "Добавленные сигналы";
            // 
            // btnEditSignal
            // 
            this.btnEditSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSignal.Location = new System.Drawing.Point(15, 356);
            this.btnEditSignal.Name = "btnEditSignal";
            this.btnEditSignal.Size = new System.Drawing.Size(71, 23);
            this.btnEditSignal.TabIndex = 3;
            this.btnEditSignal.Text = "Изменить";
            this.btnEditSignal.UseVisualStyleBackColor = true;
            this.btnEditSignal.Click += new System.EventHandler(this.btnEditSignal_Click);
            // 
            // btnDeleteSignal
            // 
            this.btnDeleteSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSignal.Location = new System.Drawing.Point(92, 356);
            this.btnDeleteSignal.Name = "btnDeleteSignal";
            this.btnDeleteSignal.Size = new System.Drawing.Size(71, 23);
            this.btnDeleteSignal.TabIndex = 2;
            this.btnDeleteSignal.Text = "Удалить";
            this.btnDeleteSignal.UseVisualStyleBackColor = true;
            this.btnDeleteSignal.Click += new System.EventHandler(this.btnDeleteSignal_Click);
            // 
            // btnNewSignal
            // 
            this.btnNewSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSignal.Location = new System.Drawing.Point(428, 356);
            this.btnNewSignal.Name = "btnNewSignal";
            this.btnNewSignal.Size = new System.Drawing.Size(115, 23);
            this.btnNewSignal.TabIndex = 1;
            this.btnNewSignal.Text = "Новый Сигнал...";
            this.btnNewSignal.UseVisualStyleBackColor = true;
            this.btnNewSignal.Click += new System.EventHandler(this.btnNewSignal_Click);
            // 
            // gvAvailableSignals
            // 
            this.gvAvailableSignals.AllowUserToAddRows = false;
            this.gvAvailableSignals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAvailableSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAvailableSignals.Location = new System.Drawing.Point(15, 19);
            this.gvAvailableSignals.Name = "gvAvailableSignals";
            this.gvAvailableSignals.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvAvailableSignals.Size = new System.Drawing.Size(528, 331);
            this.gvAvailableSignals.TabIndex = 0;
            this.gvAvailableSignals.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAvailableSignals_RowEnter);
            // 
            // SignalsCatalogViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.gbAvailableSignals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignalsCatalogViewForm";
            this.Text = "Просмотр справочника сигналов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignalsCatalogViewForm_FormClosing);
            this.Shown += new System.EventHandler(this.SignalsCatalogView_Shown);
            this.ResizeEnd += new System.EventHandler(this.SignalsCatalogViewForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.SignalsCatalogViewForm_Resize);
            this.gbAvailableSignals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAvailableSignals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAvailableSignals;
        private System.Windows.Forms.Button btnNewSignal;
        private System.Windows.Forms.DataGridView gvAvailableSignals;
        private System.Windows.Forms.Button btnEditSignal;
        private System.Windows.Forms.Button btnDeleteSignal;

    }
}