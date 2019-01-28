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
    /// Client repository.
    /// </summary>
    /// <seealso cref="IClientRepository"/>
    public class ClientRepository: IClientRepository
    {
        public Client Add(Client client, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Client Get(long personId)
        {
            throw new NotImplementedException();
        }

        public Client Edit(Client client, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }

        public void Remove(long client, bool shouldSaveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
