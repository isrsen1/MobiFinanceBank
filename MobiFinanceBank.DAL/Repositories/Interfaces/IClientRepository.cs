using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.DAL.Repositories.Interfaces
{
    /// <summary>
    /// Client repository interface.
    /// </summary>
    public interface IClientRepository
    {
        /// <summary>
        /// Adds the specified client.
        /// </summary>
        /// <param name="client">Client</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created client.</returns>
        Client Add(Client client, bool shouldSaveChanges = true);


        /// <summary>
        /// Gets the account on given date for given person.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Returns account </returns>
        Client Get(long personId);

        /// <summary>
        /// Edits the specified client.
        /// </summary>
        /// <param name="client">Client</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited client.</returns>
        /// <exception cref="ArgumentNullException">Client - client is not instantiated or Id &lt;= 0</exception>
        Client Edit(Client client, bool shouldSaveChanges = true);

        /// <summary>
        /// Removes the specified client.
        /// </summary>
        /// <param name="client">Client identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        void Remove(long client, bool shouldSaveChanges = true);
    }
}
