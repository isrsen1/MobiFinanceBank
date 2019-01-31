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
        public IExchangeService ExchangeService { get; set; }

        public ExchangeVmService(IExchangeService _exchangeService)
        {
            this.ExchangeService = _exchangeService;
        }
        public IEnumerable<CurrencyExchangeRate> RetrieveExchangeRates(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate)
        {
            try
            {
                var result = this.ExchangeService.CurrentCurrencyExchangeRate(currencies, fromDate, toDate);
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
