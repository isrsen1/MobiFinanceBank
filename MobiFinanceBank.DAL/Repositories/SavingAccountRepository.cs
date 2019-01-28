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
    /// Saving account repository.
    /// </summary>
    /// <seealso cref="ISavingAccountRepository"/>
    public class SavingAccountRepository: ISavingAccountRepository
    {
        public SavingAccount Add(SavingAccount savingAccount, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public SavingAccount Get(long personId)
        {
            throw new NotImplementedException();
        }

        public SavingAccount Edit(SavingAccount savingAccount, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long savingAccountId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
