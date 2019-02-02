using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;
using MobiFinanceBank.VmService.Interfaces;
using ClientType = MobiFinanceBank.Model.Enums.ClientType;

namespace MobiFinanceBank.VmService
{
    public class ClientOverviewVmService: IClientOverviewVmService
    {
        private readonly IClientRepository clientRepository;

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

            var clientsFiltered = clients.Where(client => client.ClientType.Name == overviewFilter.ClientType.ToString()).ToList();

            return clientsFiltered;
        }
    }
}
