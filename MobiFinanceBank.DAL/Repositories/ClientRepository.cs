using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.DbContexts.Interfaces;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using ClientType = MobiFinanceBank.Model.Enums.ClientType;

namespace MobiFinanceBank.DAL.Repositories
{
    /// <summary>
    /// Client repository.
    /// </summary>
    /// <seealso cref="IClientRepository"/>
    public class ClientRepository: IClientRepository
    {
        private readonly IMobiFinanceContext context;

        public ClientRepository(IMobiFinanceContext _context)
        {
            this.context = _context;
        }

        /// <summary>
        /// Gets all clients as queryable
        /// </summary>
        /// <returns>LINQ upgradable query</returns>
        public IQueryable<Client> GetAsQueryable()
        {
            return this.context.Clients;
        }

        /// <summary>
        /// Adds the specified client.
        /// </summary>
        /// <param name="client">Client</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> it will save changes to db.</param>
        /// <returns>Returns newly created client.</returns>
        public Client Add(Client client, bool shouldSaveChanges = true)
        {
            // Checks if client is instantiated
            if (client == null)
                throw new ArgumentNullException(nameof(client), "Client is not instantiated");

            try
            {
                var isPrivateClient = (ClientType) client.ClientTypeId == ClientType.Privatni ? true : false;
                client.FirstName = isPrivateClient ? client.FirstName : "";
                client.LastName = isPrivateClient ? client.LastName : "";
                client.CompanyName = !isPrivateClient ? client.CompanyName : "";
                
                // Adds client instance to database 
                this.context.Clients.Add(client);

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return client;
        }

        /// <summary>
        /// Gets the asset
        /// </summary>
        /// <param name="clientId">Asset id</param>
        /// <returns>Asset</returns>
        public Client Get(long clientId)
        {
            return this.context.Clients.FirstOrDefault(client => client.Id == clientId);
        }
        
        /// <summary>
        /// Edits the specified client.
        /// </summary>
        /// <param name="client">Client</param>
        /// <param name="shouldSaveChanges">if set to <c>true</c> [should save changes].</param>
        /// <returns>Returns edited client.</returns>
        /// <exception cref="ArgumentNullException">Client - client is not instantiated or Id &lt;= 0</exception>
        public Client Edit(Client client, bool shouldSaveChanges = true)
        {
            // Checks if client is instantiated
            if (client == null)
                throw new ArgumentNullException(nameof(client), "Client is not instantiated");

            try
            {
                // Modifies client
                this.context.Entry(client).State = EntityState.Modified;

                // Saves changes
                if (shouldSaveChanges)
                    this.SaveChanges();
            }
            catch (Exception e)
            {
                throw;
            }

            return client;
        }

        /// <summary>
        /// Removes the specified client.
        /// </summary>
        /// <param name="clientId">Client identifier.</param>
        /// <param name="shouldSaveChanges">if set to true it will save changes to db.</param>
        public void Remove(long clientId, bool shouldSaveChanges = true)
        {
            var client = this.Get(clientId);

            if (client == null)
                throw new ArgumentException($"Cannot delete non existing client with id {clientId}");

            this.context.Clients.Remove(client);

            if (shouldSaveChanges)
            {
                try
                {
                    this.SaveChanges();
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Saves the context changes.
        /// </summary>
        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
