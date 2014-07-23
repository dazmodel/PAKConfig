namespace PAK_Command_Editor.Settings
{
    partial class ServiceCommandsForm
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
            this.txtWriteMacros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWriteSignal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReadMacros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReadSignal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTestCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeachCommand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtWriteMacros);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtWriteSignal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReadMacros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtReadSignal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTestCommand);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTeachCommand);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст служебных команд";
            // 
            // txtWriteMacros
            // 
            this.txtWriteMacros.Location = new System.Drawing.Point(103, 133);
            this.txtWriteMacros.Name = "txtWriteMacros";
            this.txtWriteMacros.Size = new System.Drawing.Size(142, 20);
            this.txtWriteMacros.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Запись макроса: ";
            // 
            // txtWriteSignal
            // 
            this.txtWriteSignal.Location = new System.Drawing.Point(103, 110);
            this.txtWriteSignal.Name = "txtWriteSignal";
            this.txtWriteSignal.Size = new System.Drawing.Size(142, 20);
            this.txtWriteSignal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Запись сигнала: ";
            // 
            // txtReadMacros
            // 
            this.txtReadMacros.Location = new System.Drawing.Point(103, 87);
            this.txtReadMacros.Name = "txtReadMacros";
            this.txtReadMacros.Size = new System.Drawing.Size(142, 20);
            this.txtReadMacros.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Чтение макроса: ";
            // 
            // txtReadSignal
            // 
            this.txtReadSignal.Location = new System.Drawing.Point(103, 64);
            this.txtReadSignal.Name = "txtReadSignal";
            this.txtReadSignal.Size = new System.Drawing.Size(142, 20);
            this.txtReadSignal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Чтение сигнала: ";
            // 
            // txtTestCommand
            // 
            this.txtTestCommand.Location = new System.Drawing.Point(103, 40);
            this.txtTestCommand.Name = "txtTestCommand";
            this.txtTestCommand.Size = new System.Drawing.Size(142, 20);
            this.txtTestCommand.TabIndex = 3;
            this.txtTestCommand.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тест: ";
            // 
            // txtTeachCommand
            // 
            this.txtTeachCommand.Location = new System.Drawing.Point(103, 17);
            this.txtTeachCommand.Name = "txtTeachCommand";
            this.txtTeachCommand.Size = new System.Drawing.Size(142, 20);
            this.txtTeachCommand.TabIndex = 1;
            this.txtTeachCommand.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Обучение: ";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(116, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "OK";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ServiceCommandsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ServiceCommandsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройка служебных команд";
            this.Load += new System.EventHandler(this.ServiceCommandsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTestCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeachCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWriteMacros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWriteSignal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReadMacros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReadSignal;
        private System.Windows.Forms.Label label3;
    }
}