﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;
using MobiFinanceBank.Vm;

namespace MobiFinanceBank.VmService.Interfaces
{
    public interface IClientOverviewVmService
    {
        /// <summary>
        /// Gets filtered client overview data
        /// </summary>
        /// <param name="overviewFilter">Overview filter</param>
        /// <returns>Collection of clients</returns>
        IEnumerable<Client> GetClientOverview(ClientOverviewFilter overviewFilter);
    }
}
