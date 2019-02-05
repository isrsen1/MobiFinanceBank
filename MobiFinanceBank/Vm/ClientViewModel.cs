using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobiFinanceBank.Model.Models;

namespace MobiFinanceBank.Vm
{
    /// <summary>
    /// Client view model class
    /// </summary>
    public class ClientViewModel
    {
        /// <summary>
        /// Gets or sets the ClientType
        /// </summary>
        /// <value>
        /// Client type
        /// </value>
        public ClientType ClientType { get; set; }

        /// <summary>
        /// Gets or sets the Client
        /// </summary>
        /// <value>
        /// The client
        /// </value>
        public Client Client { get; set; }
    }
}
