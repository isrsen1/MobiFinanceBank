using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.DAL.Repositories.Interfaces;

namespace MobiFinanceBank.VmService
{
    public class ClientOverviewVmService
    {
        private readonly IClientRepository clientRepository;

        public ClientOverviewVmService(IClientRepository _clientRepository)
        {
            this.clientRepository = _clientRepository;
        }
    }
}
