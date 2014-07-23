namespace PAK_Command_Editor.MacrosEditor
{
    partial class MacrosesViewForm
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
            this.gvAddedMacroses = new System.Windows.Forms.DataGridView();
            this.btnAddMacros = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvAddedMacroses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvAddedMacroses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Просмотр добавленных макросов сигналов";
            // 
            // gvAddedMacroses
            // 
            this.gvAddedMacroses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAddedMacroses.Location = new System.Drawing.Point(19, 19);
            this.gvAddedMacroses.Name = "gvAddedMacroses";
            this.gvAddedMacroses.Size = new System.Drawing.Size(523, 321);
            this.gvAddedMacroses.TabIndex = 0;
            // 
            // btnAddMacros
            // 
            this.btnAddMacros.Location = new System.Drawing.Point(459, 377);
            this.btnAddMacros.Name = "btnAddMacros";
            this.btnAddMacros.Size = new System.Drawing.Size(113, 23);
            this.btnAddMacros.TabIndex = 1;
            this.btnAddMacros.Text = "Новый Макрос...";
            this.btnAddMacros.UseVisualStyleBackColor = true;
            // 
            // MacrosesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.btnAddMacros);
            this.Controls.Add(this.groupBox1);
            this.Name = "MacrosesViewForm";
            this.Text = "Добавленные макросы сигналов";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvAddedMacroses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvAddedMacroses;
        private System.Windows.Forms.Button btnAddMacros;
    }
}