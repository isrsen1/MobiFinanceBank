using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;

namespace MobiFinanceBank.Services.Interfaces
{
    /// <summary>
    /// Exchange service interface
    /// </summary>
    public interface IExchangeService
    {
        /// <summary>
        /// Get currency exchange rates
        /// </summary>
        /// <param name="currencies">List of filtered currencies</param>
        /// <param name="fromDate">From date filter</param>
        /// <param name="toDate">To date filter</param>
        /// <returns>
        /// JSON result
        /// </returns>
        string GetCurrencyExchangeRates(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate);
    }
}
