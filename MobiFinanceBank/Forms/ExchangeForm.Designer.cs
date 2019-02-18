﻿namespace MobiFinanceBank.Forms
{
    partial class ExchangeForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.currencyExchangeRateDgv = new System.Windows.Forms.DataGridView();
            this.exchangeRateListDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyExchangeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.filterLbl = new System.Windows.Forms.Label();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.ToDateLbl = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.currencyCb = new System.Windows.Forms.ComboBox();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.addCurrencyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currencyExchangeRateDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyExchangeRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // currencyExchangeRateDgv
            // 
            this.currencyExchangeRateDgv.AutoGenerateColumns = false;
            this.currencyExchangeRateDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currencyExchangeRateDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exchangeRateListDataGridViewTextBoxColumn,
            this.applicationDateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.currencyCodeDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.buyingDataGridViewTextBoxColumn,
            this.middleDataGridViewTextBoxColumn,
            this.sellingDataGridViewTextBoxColumn});
            this.currencyExchangeRateDgv.DataSource = this.currencyExchangeRateBindingSource;
            this.currencyExchangeRateDgv.Location = new System.Drawing.Point(11, 122);
            this.currencyExchangeRateDgv.Margin = new System.Windows.Forms.Padding(2);
            this.currencyExchangeRateDgv.Name = "currencyExchangeRateDgv";
            this.currencyExchangeRateDgv.Size = new System.Drawing.Size(732, 222);
            this.currencyExchangeRateDgv.TabIndex = 3;
            // 
            // exchangeRateListDataGridViewTextBoxColumn
            // 
            this.exchangeRateListDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRateList";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.exchangeRateListDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.exchangeRateListDataGridViewTextBoxColumn.HeaderText = "ExchangeRateList";
            this.exchangeRateListDataGridViewTextBoxColumn.Name = "exchangeRateListDataGridViewTextBoxColumn";
            this.exchangeRateListDataGridViewTextBoxColumn.Visible = false;
            // 
            // applicationDateDataGridViewTextBoxColumn
            // 
            this.applicationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.applicationDateDataGridViewTextBoxColumn.DataPropertyName = "ApplicationDate";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.applicationDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.applicationDateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.applicationDateDataGridViewTextBoxColumn.Name = "applicationDateDataGridViewTextBoxColumn";
            this.applicationDateDataGridViewTextBoxColumn.Width = 63;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.countryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.countryDataGridViewTextBoxColumn.HeaderText = "Država";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 66;
            // 
            // currencyCodeDataGridViewTextBoxColumn
            // 
            this.currencyCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currencyCodeDataGridViewTextBoxColumn.DataPropertyName = "CurrencyCode";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.currencyCodeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.currencyCodeDataGridViewTextBoxColumn.HeaderText = "Kod valute";
            this.currencyCodeDataGridViewTextBoxColumn.Name = "currencyCodeDataGridViewTextBoxColumn";
            this.currencyCodeDataGridViewTextBoxColumn.Width = 83;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.currencyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Valuta";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 62;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.unitDataGridViewTextBoxColumn.HeaderText = "Jedinica";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.Width = 71;
            // 
            // buyingDataGridViewTextBoxColumn
            // 
            this.buyingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.buyingDataGridViewTextBoxColumn.DataPropertyName = "Buying";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.buyingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.buyingDataGridViewTextBoxColumn.HeaderText = "Kupovni";
            this.buyingDataGridViewTextBoxColumn.Name = "buyingDataGridViewTextBoxColumn";
            this.buyingDataGridViewTextBoxColumn.Width = 71;
            // 
            // middleDataGridViewTextBoxColumn
            // 
            this.middleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.middleDataGridViewTextBoxColumn.DataPropertyName = "Middle";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.middleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.middleDataGridViewTextBoxColumn.HeaderText = "Srednji";
            this.middleDataGridViewTextBoxColumn.Name = "middleDataGridViewTextBoxColumn";
            this.middleDataGridViewTextBoxColumn.Width = 64;
            // 
            // sellingDataGridViewTextBoxColumn
            // 
            this.sellingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sellingDataGridViewTextBoxColumn.DataPropertyName = "Selling";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.sellingDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.sellingDataGridViewTextBoxColumn.HeaderText = "Prodajni";
            this.sellingDataGridViewTextBoxColumn.Name = "sellingDataGridViewTextBoxColumn";
            this.sellingDataGridViewTextBoxColumn.Width = 70;
            // 
            // currencyExchangeRateBindingSource
            // 
            this.currencyExchangeRateBindingSource.DataSource = typeof(MobiFinanceBank.Vm.CurrencyExchangeRate);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Location = new System.Drawing.Point(812, 173);
            this.dateFromPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(202, 20);
            this.dateFromPicker.TabIndex = 4;
            // 
            // filterLbl
            // 
            this.filterLbl.AutoSize = true;
            this.filterLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLbl.Location = new System.Drawing.Point(808, 113);
            this.filterLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filterLbl.Name = "filterLbl";
            this.filterLbl.Size = new System.Drawing.Size(56, 24);
            this.filterLbl.TabIndex = 5;
            this.filterLbl.Text = "Filter:";
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFromLbl.Location = new System.Drawing.Point(809, 154);
            this.dateFromLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(73, 17);
            this.dateFromLbl.TabIndex = 6;
            this.dateFromLbl.Text = "Datum od:";
            // 
            // ToDateLbl
            // 
            this.ToDateLbl.AutoSize = true;
            this.ToDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateLbl.Location = new System.Drawing.Point(809, 205);
            this.ToDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToDateLbl.Name = "ToDateLbl";
            this.ToDateLbl.Size = new System.Drawing.Size(73, 17);
            this.ToDateLbl.TabIndex = 7;
            this.ToDateLbl.Text = "Datum do:";
            // 
            // dateToPicker
            // 
            this.dateToPicker.Location = new System.Drawing.Point(812, 223);
            this.dateToPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(202, 20);
            this.dateToPicker.TabIndex = 8;
            // 
            // currencyCb
            // 
            this.currencyCb.DataSource = this.currencyExchangeRateBindingSource;
            this.currencyCb.DisplayMember = "Currency";
            this.currencyCb.FormattingEnabled = true;
            this.currencyCb.Location = new System.Drawing.Point(812, 271);
            this.currencyCb.Margin = new System.Windows.Forms.Padding(2);
            this.currencyCb.Name = "currencyCb";
            this.currencyCb.Size = new System.Drawing.Size(53, 21);
            this.currencyCb.TabIndex = 9;
            this.currencyCb.ValueMember = "Currency";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currencyLbl.Location = new System.Drawing.Point(809, 253);
            this.currencyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(52, 17);
            this.currencyLbl.TabIndex = 10;
            this.currencyLbl.Text = "Valuta:";
            // 
            // applyBtn
            // 
            this.applyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.applyBtn.Location = new System.Drawing.Point(957, 308);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(56, 27);
            this.applyBtn.TabIndex = 12;
            this.applyBtn.Text = "Primijeni";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // addCurrencyBtn
            // 
            this.addCurrencyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addCurrencyBtn.Location = new System.Drawing.Point(868, 271);
            this.addCurrencyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCurrencyBtn.Name = "addCurrencyBtn";
            this.addCurrencyBtn.Size = new System.Drawing.Size(71, 20);
            this.addCurrencyBtn.TabIndex = 13;
            this.addCurrencyBtn.Text = "Dodaj valutu";
            this.addCurrencyBtn.UseVisualStyleBackColor = true;
            this.addCurrencyBtn.Click += new System.EventHandler(this.addCurrencyBtn_Click);
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 518);
            this.Controls.Add(this.addCurrencyBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.currencyLbl);
            this.Controls.Add(this.currencyCb);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.ToDateLbl);
            this.Controls.Add(this.dateFromLbl);
            this.Controls.Add(this.filterLbl);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.currencyExchangeRateDgv);
            this.KeyPreview = true;
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExchangeForm_FormClosing);
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExchangeForm_KeyDown);
            this.Controls.SetChildIndex(this.currencyExchangeRateDgv, 0);
            this.Controls.SetChildIndex(this.dateFromPicker, 0);
            this.Controls.SetChildIndex(this.filterLbl, 0);
            this.Controls.SetChildIndex(this.dateFromLbl, 0);
            this.Controls.SetChildIndex(this.ToDateLbl, 0);
            this.Controls.SetChildIndex(this.dateToPicker, 0);
            this.Controls.SetChildIndex(this.currencyCb, 0);
            this.Controls.SetChildIndex(this.currencyLbl, 0);
            this.Controls.SetChildIndex(this.applyBtn, 0);
            this.Controls.SetChildIndex(this.addCurrencyBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.currencyExchangeRateDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyExchangeRateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView currencyExchangeRateDgv;
        private System.Windows.Forms.BindingSource currencyExchangeRateBindingSource;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label filterLbl;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.Label ToDateLbl;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.ComboBox currencyCb;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button addCurrencyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateListDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingDataGridViewTextBoxColumn;
    }
}