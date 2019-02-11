using System;
using System.Collections.Generic;
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
        private readonly IExchangeService exchangeService;

        /// <summary>
        /// Initializes new instance of exchange view model service
        /// </summary>
        /// <param name="_exchangeService">Exchange service</param>
        public ExchangeVmService(IExchangeService _exchangeService)
        {
            this.exchangeService = _exchangeService;
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
                var result = this.exchangeService.GetCurrencyExchangeRates(currencies, fromDate, toDate);
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
