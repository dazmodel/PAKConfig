using NHibernate;
using PAK_Command_Editor.HardwareInteractionModule;
using PAK_Command_Editor.MacrosEditor;
using PAK_Command_Editor.Repository;
using PAK_Command_Editor.Settings;
using PAK_Command_Editor.SignalsCatalog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PAK_Command_Editor
{
    public partial class MainForm : Form
    {        
        private MacrosesEditorForm _macrosesEditor;
        public MainForm()
        {
            InitializeComponent();            
        }

        #region MainForm Event Handlers

        private void ExitAppMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion        

        #region Main Menu Event Handlers

        private void openSignalsCatalogMenuItemClick(object sender, EventArgs e)
        {
            SignalsCatalogViewForm signalsViewForm = new SignalsCatalogViewForm();
            signalsViewForm.MdiParent = this;
            signalsViewForm.Show();
        }        

        private void addSignalMenuItem_Click(object sender, EventArgs e)
        {
            AddSignalForm addSignalForm = new AddSignalForm();            
            addSignalForm.ShowDialog();
        }

        private void dbConfigMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseLocationForm dataBaseLocationForm = new DataBaseLocationForm();
            dataBaseLocationForm.ShowDialog();
        }

        private void teachingConfigMenuItem_Click(object sender, EventArgs e)
        {
            ServiceCommandsForm serviceCommandsForm = new ServiceCommandsForm();
            serviceCommandsForm.ShowDialog();
        }

        private void comPortConfigMenuItem_Click(object sender, EventArgs e)
        {
            COMPortSettingsForm comPortSettingsForm = new COMPortSettingsForm();
            comPortSettingsForm.ShowDialog();
        }

        private void macrosEditorMenuItem_Click(object sender, EventArgs e)
        {
            MacrosesEditorForm macrosEditor = new MacrosesEditorForm();
            macrosEditor.MdiParent = this;
            macrosEditor.FormClosing += macrosEditor_FormClosing;
            macrosEditor.MacrosChanged += macrosEditor_MacrosChanged;
            macrosEditor.MacrosReadyToSave += macrosEditor_MacrosReadyToSave;
            macrosEditor.Show();

            this.exportMacrosMenuItem.Enabled = true;
            this._macrosesEditor = macrosEditor;
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            this.dlgOpenMacrosFile.ShowDialog();
        }

        private void exportMacrosMenuItem_Click(object sender, EventArgs e)
        {
            this.dlgExportMacros.ShowDialog();
        }

        private void readMacrosFromDeviceMenuItem_Click(object sender, EventArgs e)
        {
            KeyValuePair<String, MacrosesContainer> readedMacros;
            using (PAKHardwareInteractionModule hwModule = new PAKHardwareInteractionModule())
            {
                readedMacros = hwModule.ReadMacrosFromDevice();
            }

            MessageBox.Show(readedMacros.Key);

            if (readedMacros.Value != null)
            {
                MacrosesEditorForm macrosEditor = new MacrosesEditorForm();
                macrosEditor.MdiParent = this;
                macrosEditor.FormClosing += macrosEditor_FormClosing;
                macrosEditor.MacrosChanged += macrosEditor_MacrosChanged;
                macrosEditor.MacrosReadyToSave += macrosEditor_MacrosReadyToSave;
                macrosEditor.MacrosesContainer = readedMacros.Value;
                macrosEditor.Show();

                this.exportMacrosMenuItem.Enabled = true;
                this._macrosesEditor = macrosEditor;
            }
        }

        private void loadMacrosToDeviceMenuItem_Click(object sender, EventArgs e)
        {
            this._macrosesEditor.SendMacrosToDevice();
        }

        #endregion

        #region Macroses Editor Event Handlers

        void macrosEditor_MacrosChanged(object sender, EventArgs e)
        {
            this.loadMacrosToDeviceMenuItem.Enabled = this._macrosesEditor.MacrosConfigured;
        }

        void macrosEditor_MacrosReadyToSave(object sender, EventArgs e)
        {
            this.dlgExportMacros.ShowDialog();
        }

        void macrosEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.exportMacrosMenuItem.Enabled = false;
            this.loadMacrosToDeviceMenuItem.Enabled = false;
        }

        #endregion

        #region File Open/Save Dialogs Event Handlers

        private void dlgOpenMacrosFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MacrosesEditorForm macrosEditor = new MacrosesEditorForm();
            macrosEditor.MdiParent = this;
            macrosEditor.FormClosing += macrosEditor_FormClosing;
            macrosEditor.MacrosChanged += macrosEditor_MacrosChanged;
            macrosEditor.MacrosReadyToSave += macrosEditor_MacrosReadyToSave;
            macrosEditor.MacrosFileName = this.dlgOpenMacrosFile.FileName;
            macrosEditor.Show();

            this.exportMacrosMenuItem.Enabled = true;
            this.loadMacrosToDeviceMenuItem.Enabled = true;
            this._macrosesEditor = macrosEditor;
        }

        private void dlgExportMacros_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this._macrosesEditor.SaveMacros(this.dlgExportMacros.FileName);
        }

        #endregion                            
    }
}
