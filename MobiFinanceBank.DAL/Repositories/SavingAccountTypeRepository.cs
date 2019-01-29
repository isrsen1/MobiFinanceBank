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
    /// Saving account type repository.
    /// </summary>
    /// <seealso cref="ISavingAccountTypeRepository"/>
    public class SavingAccountTypeRepository: ISavingAccountTypeRepository
    {
        public SavingAccountType Add(SavingAccountType savingAccountType, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public SavingAccountType Get(long personId)
        {
            throw new NotImplementedException();
        }

        public SavingAccountType Edit(SavingAccountType savingAccountType, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long savingAccountTypeId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
