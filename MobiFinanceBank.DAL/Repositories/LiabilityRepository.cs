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
    /// Liability repository.
    /// </summary>
    /// <seealso cref="ILiabilityRepository"/>
    public class LiabilityRepository: ILiabilityRepository
    {
        public Liability Add(Liability liability, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Liability Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Liability Edit(Liability liability, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long liabilityId, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
