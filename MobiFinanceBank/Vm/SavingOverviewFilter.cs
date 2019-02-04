using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Vm
{
    /// <summary>
    /// Saving account overview filter
    /// </summary>
    public class SavingOverviewFilter
    {
        /// <summary>
        /// Gets or sets the client
        /// </summary>
        /// <value>
        /// The client 
        /// </value>
        public Client Client { get; set; }
    }
}
