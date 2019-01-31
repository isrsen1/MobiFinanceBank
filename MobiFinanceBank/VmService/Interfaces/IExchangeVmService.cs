using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;
using MobiFinanceBank.Vm;

namespace MobiFinanceBank.VmService.Interfaces
{
    public interface IExchangeVmService
    {
        IEnumerable<CurrencyExchangeRate> RetrieveExchangeRates(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate);
    }
}
