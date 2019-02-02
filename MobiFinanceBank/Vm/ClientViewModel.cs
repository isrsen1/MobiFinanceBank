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
        public ClientType ClientType { get; set; }

        /// <summary>
        /// Gets or sets the Client
        /// </summary>
        public Client Client { get; set; }
    }
}
