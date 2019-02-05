using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Enums;

namespace MobiFinanceBank.Vm
{
    /// <summary>
    /// Client overview filter
    /// </summary>
    public class ClientOverviewFilter
    {
        /// <summary>
        /// Gets or sets the client type enum
        /// </summary>
        /// <value>
        /// Client type
        /// </value>
        public ClientType ClientType { get; set; }
    }
}
