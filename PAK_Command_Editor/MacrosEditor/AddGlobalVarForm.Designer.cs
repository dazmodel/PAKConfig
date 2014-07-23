namespace PAK_Command_Editor.MacrosEditor
{
    partial class AddGlobalVarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGlobalVarValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGlobalVarAlias = new System.Windows.Forms.TextBox();
            this.btnAddVar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbGlobalVarValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGlobalVarAlias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // cbGlobalVarValue
            // 
            this.cbGlobalVarValue.FormattingEnabled = true;
            this.cbGlobalVarValue.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cbGlobalVarValue.Location = new System.Drawing.Point(84, 51);
            this.cbGlobalVarValue.Name = "cbGlobalVarValue";
            this.cbGlobalVarValue.Size = new System.Drawing.Size(100, 21);
            this.cbGlobalVarValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значение: ";
            // 
            // txtGlobalVarAlias
            // 
            this.txtGlobalVarAlias.Location = new System.Drawing.Point(84, 19);
            this.txtGlobalVarAlias.MaxLength = 4;
            this.txtGlobalVarAlias.Name = "txtGlobalVarAlias";
            this.txtGlobalVarAlias.Size = new System.Drawing.Size(100, 20);
            this.txtGlobalVarAlias.TabIndex = 1;
            this.txtGlobalVarAlias.TextChanged += new System.EventHandler(this.txtGlobalVarAlias_TextChanged);
            // 
            // btnAddVar
            // 
            this.btnAddVar.Enabled = false;
            this.btnAddVar.Location = new System.Drawing.Point(56, 118);
            this.btnAddVar.Name = "btnAddVar";
            this.btnAddVar.Size = new System.Drawing.Size(75, 23);
            this.btnAddVar.TabIndex = 2;
            this.btnAddVar.Text = "ОК";
            this.btnAddVar.UseVisualStyleBackColor = true;
            this.btnAddVar.Click += new System.EventHandler(this.btnAddVar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddGlobalVarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 151);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddVar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddGlobalVarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Новая переменная";
            this.Load += new System.EventHandler(this.AddGlobalVarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGlobalVarValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGlobalVarAlias;
        private System.Windows.Forms.Button btnAddVar;
        private System.Windows.Forms.Button btnCancel;
    }
}