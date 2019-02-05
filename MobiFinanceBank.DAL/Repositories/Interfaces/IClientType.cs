using System.Collections.Generic;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    public interface IClientTypeRepository
    {
        
        /// <summary>
        /// Gets the client type.
        /// </summary>
        /// <param name="clientTypeId">The person identifier.</param>
        /// <returns>Returns ClientType </returns>
        ClientType Get(long clientTypeId);

        /// <summary>
        /// Gets all client types.
        /// </summary>
        /// <returns>Returns client types </returns>
        IEnumerable<ClientType> GetAll();

    }
}
