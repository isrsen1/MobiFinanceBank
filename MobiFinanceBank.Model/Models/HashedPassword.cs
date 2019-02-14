using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    

    /// <summary>
    /// Employee type database model class.
    /// </summary>
    [Table("HashedPassword")]
    public partial class HashedPassword
    {
        public HashedPassword()
        {
            
        }
        /// <summary>
        /// Gets or sets employee's hashed password ID
        /// </summary>
        /// <value>
        /// Hashed Password id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets employee's hashed password hash
        /// </summary>
        /// <value>
        /// Employee type name
        /// </value>
        public string Hash { get; set; }

        /// <summary>
        /// Gets or sets employee's hashed password Salt
        /// </summary>
        /// <value>
        /// employee's hashed password salt
        /// </value>
        public string Salt { get; set; }
    }
}
