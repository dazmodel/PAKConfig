namespace PAK_Command_Editor.MacrosEditor
{
    partial class SelectCommandTypeForm
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
            this.btnSetCommandType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbCommandType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSetCommandType
            // 
            this.btnSetCommandType.Enabled = false;
            this.btnSetCommandType.Location = new System.Drawing.Point(61, 40);
            this.btnSetCommandType.Name = "btnSetCommandType";
            this.btnSetCommandType.Size = new System.Drawing.Size(75, 23);
            this.btnSetCommandType.TabIndex = 0;
            this.btnSetCommandType.Text = "ОК";
            this.btnSetCommandType.UseVisualStyleBackColor = true;
            this.btnSetCommandType.Click += new System.EventHandler(this.btnSetCommandType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbCommandType
            // 
            this.cbCommandType.FormattingEnabled = true;
            this.cbCommandType.Location = new System.Drawing.Point(13, 13);
            this.cbCommandType.Name = "cbCommandType";
            this.cbCommandType.Size = new System.Drawing.Size(203, 21);
            this.cbCommandType.TabIndex = 2;
            this.cbCommandType.SelectedIndexChanged += new System.EventHandler(this.cbCommandType_SelectedIndexChanged);
            // 
            // SelectCommandTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 74);
            this.Controls.Add(this.cbCommandType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetCommandType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SelectCommandTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тип команды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectCommandTypeForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectCommandTypeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSetCommandType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbCommandType;
    }
}