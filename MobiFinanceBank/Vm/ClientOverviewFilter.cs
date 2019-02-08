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

        /// <summary>
        /// Gets or sets the client first name
        /// </summary>
        /// <value>
        /// Client first name
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the client last name
        /// </summary>
        /// <value>
        /// Client last name
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        /// <value>
        /// The company name
        /// </value>
        public string Company { get; set; }
    }
}
