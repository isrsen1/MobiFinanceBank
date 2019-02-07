using System.Collections.Generic;
using System.Linq;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using ClientType = MobiFinanceBank.Model.Enums.ClientType;

namespace MobiFinanceBank.VmService
{
    /// <summary>
    /// Client overview view model service
    /// </summary>
    /// <seealso cref="IClientOverviewVmService"/>
    public class ClientOverviewVmService: IClientOverviewVmService
    {
        private readonly IClientRepository clientRepository;

        /// <summary>
        /// Initializes new instance of client overview view model service
        /// </summary>
        /// <param name="_clientRepository">Client repository</param>
        public ClientOverviewVmService(IClientRepository _clientRepository)
        {
            this.clientRepository = _clientRepository;
        }

        /// <summary>
        /// Gets filtered client overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of clients</returns>
        public IEnumerable<Client> GetClientOverview(ClientOverviewFilter overviewFilter)
        {
            var clients = this.clientRepository.GetAsQueryable();

            if (overviewFilter.ClientType == ClientType.Privatni)
            {
                if (!string.IsNullOrEmpty(overviewFilter.FirstName))
                    clients = clients.Where(client => client.FirstName.Contains(overviewFilter.FirstName));

                if (!string.IsNullOrEmpty(overviewFilter.LastName))
                    clients = clients.Where(client => client.LastName.Contains(overviewFilter.LastName));
            }

            if (overviewFilter.ClientType == ClientType.Poslovni)
            {
                if (!string.IsNullOrEmpty(overviewFilter.Company))
                    clients = clients.Where(client => client.CompanyName.Contains(overviewFilter.Company));
            }

            var clientsFiltered = clients.Where(client => client.ClientType.Name == overviewFilter.ClientType.ToString()).ToList();

            return clientsFiltered;
        }
    }
}
