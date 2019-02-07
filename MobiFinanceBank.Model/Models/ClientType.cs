using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    [Table("ClientType")]
    public class ClientType
    {
        /// <summary>
        /// Initializes new client instance
        /// </summary>
        public ClientType()
        {
            Clients = new HashSet<Client>();

        }

        /// <summary>
        /// Gets or sets the client type id
        /// </summary>
        /// <value>
        /// Clients id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the client type name
        /// </summary>
        /// <value>
        /// Clients id
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets clients of this type
        /// </summary>
        /// Clients collection
        public virtual ICollection<Client> Clients { get; set; }
    }
}
