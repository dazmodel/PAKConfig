namespace PAK_Command_Editor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMacrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникСигналовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSignalsCatalogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSignalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторМакросовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macrosEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.устройствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMacrosFromDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMacrosToDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dbConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachingConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.dlgOpenMacrosFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgExportMacros = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникСигналовToolStripMenuItem,
            this.редакторМакросовToolStripMenuItem,
            this.устройствоToolStripMenuItem,
            this.настройкаToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.exportMacrosMenuItem,
            this.toolStripSeparator1,
            this.exitAppMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openFileMenuItem.Text = "Открыть...";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // exportMacrosMenuItem
            // 
            this.exportMacrosMenuItem.Enabled = false;
            this.exportMacrosMenuItem.Name = "exportMacrosMenuItem";
            this.exportMacrosMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exportMacrosMenuItem.Text = "Экспорт...";
            this.exportMacrosMenuItem.Click += new System.EventHandler(this.exportMacrosMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // exitAppMenuItem
            // 
            this.exitAppMenuItem.Name = "exitAppMenuItem";
            this.exitAppMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exitAppMenuItem.Text = "Выход";
            this.exitAppMenuItem.Click += new System.EventHandler(this.ExitAppMenuItemClick);
            // 
            // справочникСигналовToolStripMenuItem
            // 
            this.справочникСигналовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSignalsCatalogMenuItem,
            this.addSignalMenuItem});
            this.справочникСигналовToolStripMenuItem.Name = "справочникСигналовToolStripMenuItem";
            this.справочникСигналовToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.справочникСигналовToolStripMenuItem.Text = "Справочник Сигналов";
            // 
            // openSignalsCatalogMenuItem
            // 
            this.openSignalsCatalogMenuItem.Name = "openSignalsCatalogMenuItem";
            this.openSignalsCatalogMenuItem.Size = new System.Drawing.Size(178, 22);
            this.openSignalsCatalogMenuItem.Text = "Открыть...";
            this.openSignalsCatalogMenuItem.Click += new System.EventHandler(this.openSignalsCatalogMenuItemClick);
            // 
            // addSignalMenuItem
            // 
            this.addSignalMenuItem.Name = "addSignalMenuItem";
            this.addSignalMenuItem.Size = new System.Drawing.Size(178, 22);
            this.addSignalMenuItem.Text = "Добавить Сигнал...";
            this.addSignalMenuItem.Click += new System.EventHandler(this.addSignalMenuItem_Click);
            // 
            // редакторМакросовToolStripMenuItem
            // 
            this.редакторМакросовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macrosEditorMenuItem});
            this.редакторМакросовToolStripMenuItem.Name = "редакторМакросовToolStripMenuItem";
            this.редакторМакросовToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.редакторМакросовToolStripMenuItem.Text = "Макросы";
            // 
            // macrosEditorMenuItem
            // 
            this.macrosEditorMenuItem.Name = "macrosEditorMenuItem";
            this.macrosEditorMenuItem.Size = new System.Drawing.Size(190, 22);
            this.macrosEditorMenuItem.Text = "Редактор макросов...";
            this.macrosEditorMenuItem.Click += new System.EventHandler(this.macrosEditorMenuItem_Click);
            // 
            // устройствоToolStripMenuItem
            // 
            this.устройствоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMacrosFromDeviceMenuItem,
            this.loadMacrosToDeviceMenuItem});
            this.устройствоToolStripMenuItem.Name = "устройствоToolStripMenuItem";
            this.устройствоToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.устройствоToolStripMenuItem.Text = "Устройство";
            // 
            // readMacrosFromDeviceMenuItem
            // 
            this.readMacrosFromDeviceMenuItem.Name = "readMacrosFromDeviceMenuItem";
            this.readMacrosFromDeviceMenuItem.Size = new System.Drawing.Size(172, 22);
            this.readMacrosFromDeviceMenuItem.Text = "Считать макрос";
            this.readMacrosFromDeviceMenuItem.Click += new System.EventHandler(this.readMacrosFromDeviceMenuItem_Click);
            // 
            // loadMacrosToDeviceMenuItem
            // 
            this.loadMacrosToDeviceMenuItem.Enabled = false;
            this.loadMacrosToDeviceMenuItem.Name = "loadMacrosToDeviceMenuItem";
            this.loadMacrosToDeviceMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadMacrosToDeviceMenuItem.Text = "Загрузить макрос";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dbConfigMenuItem,
            this.teachingConfigMenuItem,
            this.comPortConfigMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // dbConfigMenuItem
            // 
            this.dbConfigMenuItem.Name = "dbConfigMenuItem";
            this.dbConfigMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dbConfigMenuItem.Text = "База данных...";
            this.dbConfigMenuItem.Click += new System.EventHandler(this.dbConfigMenuItem_Click);
            // 
            // teachingConfigMenuItem
            // 
            this.teachingConfigMenuItem.Name = "teachingConfigMenuItem";
            this.teachingConfigMenuItem.Size = new System.Drawing.Size(169, 22);
            this.teachingConfigMenuItem.Text = "Старт-команды...";
            this.teachingConfigMenuItem.Click += new System.EventHandler(this.teachingConfigMenuItem_Click);
            // 
            // comPortConfigMenuItem
            // 
            this.comPortConfigMenuItem.Name = "comPortConfigMenuItem";
            this.comPortConfigMenuItem.Size = new System.Drawing.Size(169, 22);
            this.comPortConfigMenuItem.Text = "COM-порт...";
            this.comPortConfigMenuItem.Click += new System.EventHandler(this.comPortConfigMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 540);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // dlgOpenMacrosFile
            // 
            this.dlgOpenMacrosFile.Filter = "ПАК макросы|*.macros";
            this.dlgOpenMacrosFile.Title = "Открытие файла ПАК макроса";
            this.dlgOpenMacrosFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenMacrosFile_FileOk);
            // 
            // dlgExportMacros
            // 
            this.dlgExportMacros.DefaultExt = "macros";
            this.dlgExportMacros.Filter = "ПАК макросы|*.macros";
            this.dlgExportMacros.Title = "Экспорт ПАК макроса";
            this.dlgExportMacros.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgExportMacros_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ПАК-Конфигурация";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportMacrosMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitAppMenuItem;
        private System.Windows.Forms.ToolStripMenuItem устройствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMacrosFromDeviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMacrosToDeviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dbConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachingConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortConfigMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem справочникСигналовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSignalsCatalogMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSignalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторМакросовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macrosEditorMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpenMacrosFile;
        private System.Windows.Forms.SaveFileDialog dlgExportMacros;
    }
}