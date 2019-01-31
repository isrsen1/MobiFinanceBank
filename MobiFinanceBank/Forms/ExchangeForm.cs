using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobiFinanceBank.Forms.Interfaces;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.Templates;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using Newtonsoft.Json;

namespace MobiFinanceBank.Forms
{
    /// <summary>
    /// Exchange form
    /// </summary>
    public partial class ExchangeForm : TemplateForm, IExchangeForm
    {
        private IExchangeVmService exchangeVmService;
        public List<Currency> Currencies { get; set; } = new List<Currency>();

        /// <summary>
        /// Creates new instance of exchange form
        /// </summary>
        /// <param name="_exchangeVmService">Exchange vm service</param>
        public ExchangeForm(IExchangeVmService _exchangeVmService)
        {
            InitializeComponent();
            this.exchangeVmService = _exchangeVmService;

        }

        /// <summary>
        /// On exchange form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExchangeForm_Load(object sender, EventArgs e)
        {
            var result = this.exchangeVmService.RetrieveExchangeRates(null, null, null);

            if (result == null)
            {
                MessageBox.Show("Neuspjeh pri dohvatu tečaja", "Tečaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            currencyExchangeRateDgv.DataSource = result;
            currencyCb.DataSource = result;
        }

        /// <summary>
        /// Sends api request to HNB on apply button click
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">event args</param>
        private void applyBtn_Click(object sender, EventArgs e)
        {
            // Extract filter data
            var dateFrom = dateFromPicker.Value;
            var dateTo = dateToPicker.Value;

            // Gets api request result and changes grid view data source
            var result = this.exchangeVmService.RetrieveExchangeRates(Currencies, dateFrom, dateTo);
            currencyExchangeRateDgv.DataSource = result;
            Currencies = null;
        }

        /// <summary>
        /// Adds filter currency to list
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void addCurrencyBtn_Click(object sender, EventArgs e)
        {
            // Parses currency to enum, checks if currency exists in list and adds it if not
            var currency = Enum.Parse(typeof(Currency), currencyCb.SelectedValue.ToString());
            if(!Currencies.Contains((Currency)currency)) Currencies.Add((Currency)currency); 
        }
    }
}
