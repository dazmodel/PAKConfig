using PAK_Command_Editor.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PAK_Command_Editor.Repository;
using NHibernate;

namespace PAK_Command_Editor.SignalsCatalog
{
    public partial class SignalsCatalogViewForm : Form
    {
        private static readonly String SIGNALS_CATALOG_CAPTION = "Справочник Сигналов";
        private static readonly String EMPTY_SIGNALS_MESSAGE = "В текущем Справочнике еще нет сигналов. \r\nВоспользуйтесь кнопкой Новый Сигнал... для добавления.";
        private static readonly String DG_SIGNAL_ID = "Id Сигнала";
        private static readonly String DG_SIGNAL_NAME = "Имя сигнала";
        private static readonly String DG_DEVICE_NAME = "Усройство";
        private static readonly String DG_VENDOR_NAME = "Производитель";
        private static readonly String DG_HEX_CODE = "HEX-код";
        private static readonly String DELETE_SIGNAL_TITLE = "Удаление сигнала";
        private static readonly String DELETE_SIGNAL_MSG = "Вы действительно хотите удалить сигнал {0}?";
        private IRepository<Vendor> _vendorsRepo;
        private IRepository<Signal> _signalsRepo; 
        private ISession _dataSession;
        private Int32 _currentSignalId;

        private int _prevWidth;
        private FormWindowState _prevWindowState;

        public SignalsCatalogViewForm()
        {
            this.InitializeComponent();
            this._prevWidth = this.Width;
            this._prevWindowState = this.WindowState;

            this._dataSession = PAKDataSessionFactory.GetSession();
            this._vendorsRepo = new Repository<Vendor>(this._dataSession);
            this._signalsRepo = new Repository<Signal>(this._dataSession);
        }        

        private void SignalsCatalogView_Shown(object sender, EventArgs e)
        {
            IQueryable<Signal> signals = this._signalsRepo.GetAll();

            if (!signals.Any())
            {
                MessageBox.Show(EMPTY_SIGNALS_MESSAGE, SIGNALS_CATALOG_CAPTION);
            }
            else
            {
                this.BindSignalsGrid(signals);
            }
        }

        private void btnNewSignal_Click(object sender, EventArgs e)
        {
            AddSignalForm addSignalForm = new AddSignalForm();
            addSignalForm.ParentFormRef  = this.Parent as Form;
            addSignalForm.SignalAdded += addSignalForm_SignalAdded;
            addSignalForm.ShowDialog();
        }

        void addSignalForm_SignalAdded(object sender, CustomEventArgs.ResultEntityEventArgs e)
        {
            IQueryable<Signal> signals = this._signalsRepo.GetAll();
            this.BindSignalsGrid(signals);
        }

        #region Utilities

        private void BindSignalsGrid(IQueryable<Signal> signals)
        {
            this.gvAvailableSignals.DataSource = null;

            //Set AutoGenerateColumns False
            this.gvAvailableSignals.AutoGenerateColumns = false;

            //Set Columns Count
            this.gvAvailableSignals.ColumnCount = 5;

            //Add Columns
            this.gvAvailableSignals.Columns[0].Name = "Id";
            this.gvAvailableSignals.Columns[0].HeaderText = DG_SIGNAL_ID;
            this.gvAvailableSignals.Columns[0].DataPropertyName = "Id";
                        
            this.gvAvailableSignals.Columns[1].Name = "SignalName";
            this.gvAvailableSignals.Columns[1].HeaderText = DG_SIGNAL_NAME;
            this.gvAvailableSignals.Columns[1].DataPropertyName = "SignalName";

            this.gvAvailableSignals.Columns[2].Name = "DeviceName";
            this.gvAvailableSignals.Columns[2].HeaderText = DG_DEVICE_NAME;
            this.gvAvailableSignals.Columns[2].DataPropertyName = "DeviceName";

            this.gvAvailableSignals.Columns[3].Name = "VendorName";
            this.gvAvailableSignals.Columns[3].HeaderText = DG_VENDOR_NAME;
            this.gvAvailableSignals.Columns[3].DataPropertyName = "VendorName";

            this.gvAvailableSignals.Columns[4].Name = "HEXCode";
            this.gvAvailableSignals.Columns[4].HeaderText = DG_HEX_CODE;
            this.gvAvailableSignals.Columns[4].DataPropertyName = "HEXCode";
            
            var dataSource =
                signals.Select(
                    x =>
                    new SignalViewEntity()
                        {
                            Id = x.Id,
                            SignalName = x.Name,
                            DeviceName = x.Device.Name,
                            VendorName = x.Device.Vendor.Name,
                            HEXCode = x.HexCode
                        }).ToList();

            this.gvAvailableSignals.DataSource = dataSource;
        }

        private void ResizeGrid(DataGridView dataGrid, ref int prevWidth)
        {
            if (prevWidth == 0)
                prevWidth = dataGrid.Width;
            if (prevWidth == dataGrid.Width)
                return;

            int fixedWidth = SystemInformation.VerticalScrollBarWidth +
            dataGrid.RowHeadersWidth + 2;
            int mul = 100 * (dataGrid.Width - fixedWidth) /
            (prevWidth - fixedWidth);
            int columnWidth;
            int total = 0;
            DataGridViewColumn lastVisibleCol = null;

            for (int i = 0; i < dataGrid.ColumnCount; i++)
                if (dataGrid.Columns[i].Visible)
                {
                    columnWidth = (dataGrid.Columns[i].Width * mul + 50) / 100;
                    dataGrid.Columns[i].Width =
                    Math.Max(columnWidth, dataGrid.Columns[i].MinimumWidth);
                    total += dataGrid.Columns[i].Width;
                    lastVisibleCol = dataGrid.Columns[i];
                }
            if (lastVisibleCol == null)
                return;
            columnWidth = dataGrid.Width - total +
            lastVisibleCol.Width - fixedWidth;
            lastVisibleCol.Width =
            Math.Max(columnWidth, lastVisibleCol.MinimumWidth);
            prevWidth = dataGrid.Width;
        }

        #endregion

        private void gvAvailableSignals_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this._currentSignalId = Convert.ToInt32(this.gvAvailableSignals.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnDeleteSignal_Click(object sender, EventArgs e)
        {
            if (this._currentSignalId > 0)
            {
                Signal signalTodelete = this._signalsRepo.Get(x => x.Id == this._currentSignalId).SingleOrDefault();
                DialogResult dr = MessageBox.Show(String.Format(DELETE_SIGNAL_MSG, signalTodelete.Name), DELETE_SIGNAL_TITLE,
                                                  MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    using (ITransaction transaction = this._dataSession.BeginTransaction())
                    {
                        this._signalsRepo.Delete(signalTodelete);
                        transaction.Commit();
                    }

                    this.BindSignalsGrid(this._signalsRepo.GetAll());
                }
            }
        }

        private void btnEditSignal_Click(object sender, EventArgs e)
        {
            if (this._currentSignalId > 0)
            {
                EditSignalForm editSignalForm = new EditSignalForm(this._currentSignalId);
                editSignalForm.SignalChanged += editSignalForm_SignalChanged;
                editSignalForm.ShowDialog();
            }
        }

        void editSignalForm_SignalChanged(object sender, CustomEventArgs.ResultEntityEventArgs e)
        {
            this.BindSignalsGrid(this._signalsRepo.GetAll());
        }

        private void SignalsCatalogViewForm_ResizeEnd(object sender, EventArgs e)
        {
            this.ResizeGrid(this.gvAvailableSignals, ref this._prevWidth);
        }

        private void SignalsCatalogViewForm_Resize(object sender, EventArgs e)
        {
            if ((this.WindowState != this._prevWindowState) && (this.WindowState != FormWindowState.Minimized))
            {
                this._prevWindowState = this.WindowState;
                ResizeGrid(this.gvAvailableSignals, ref this._prevWidth);
            }
        }

        private void SignalsCatalogViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._dataSession == null) return;

            try
            {
                if (this._dataSession.Transaction.IsActive)
                    this._dataSession.Transaction.Commit();
            }
            catch (Exception)
            {
                if (this._dataSession.Transaction.IsActive)
                    this._dataSession.Transaction.Rollback();
            }
            finally
            {
                this._dataSession.Close();
                this._dataSession.Dispose();
            }
        }        
    }
}
