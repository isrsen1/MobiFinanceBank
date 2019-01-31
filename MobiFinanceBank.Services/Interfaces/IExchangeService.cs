using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;

namespace MobiFinanceBank.Services.Interfaces
{
    public interface IExchangeService
    {
        string CurrentCurrencyExchangeRate(IEnumerable<Currency> currencies, DateTime? fromDate, DateTime? toDate);
    }
}
