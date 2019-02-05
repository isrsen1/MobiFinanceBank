using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Services.Interfaces;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using Newtonsoft.Json;

namespace MobiFinanceBank.VmService
{
    /// <summary>
    /// Exchange view model service
    /// </summary>
    public class ExchangeVmService: IExchangeVmService
    {
        /// <summary>
        /// Gets or sets the exchange service
        /// </summary>
        /// <value>
        /// The exchange service
        /// </value>
        public IExchangeService ExchangeService { get; set; }

        /// <summary>
        /// Initializes new instance of exchange view model service
        /// </summary>
        /// <param name="_exchangeService">Exchange service</param>
        public ExchangeVmService(IExchangeService _exchangeService)
        {
            this.ExchangeService = _exchangeService;
        }

        /// <summary>
        /// Retrieves the collection of exchange rates
        /// </summary>
        /// <param name="currencies">Collection of currencies</param>
        /// <param name="fromDate">From date filter</param>
        /// <param name="toDate">To date filter</param>
        /// <returns></returns>
        public IEnumerable<CurrencyExchangeRate> RetrieveExchangeRates(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate)
        {
            try
            {
                // Retrieve values from service
                var result = this.ExchangeService.GetCurrencyExchangeRates(currencies, fromDate, toDate);
                var resultJson = JsonConvert.DeserializeObject<IEnumerable<CurrencyExchangeRate>>(result);

                return resultJson;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
