using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Client type repository
    /// </summary>
    public class ClientTypeRepository: IClientTypeRepository
    {
        private IMobiFinanceContext context;

        /// <summary>
        /// Gets the client type based on id
        /// </summary>
        /// <param name="clientTypeId">Client type id</param>
        /// <returns>Client type</returns>
        public ClientType Get(long clientTypeId)
        {
            return this.context.ClientTypes.FirstOrDefault(ct => ct.Id == clientTypeId);
        }

        public IEnumerable<ClientType> GetAll()
        {
            return this.context.ClientTypes.ToList();
        }
    }
}
