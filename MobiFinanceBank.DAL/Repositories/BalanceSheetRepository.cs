using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Balance sheet repository.
    /// </summary>
    /// <seealso cref="IBalanceSheetRepository"/>
    public class BalanceSheetRepository: IBalanceSheetRepository
    {
        public BalanceSheet Add(BalanceSheet balanceSheet, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public BalanceSheet Get(long personId)
        {
            throw new NotImplementedException();
        }

        public BalanceSheet Edit(BalanceSheet balanceSheet, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long balanceSheetId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
