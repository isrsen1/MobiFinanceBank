using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Account type database model class.
    /// </summary>
    [Table("AccountType")]
    public partial class AccountType
    {
        /// <summary>
        /// Initializes new instance of account type
        /// </summary>
        public AccountType()
        {
            Accounts = new HashSet<Account>();
        }

        /// <summary>
        /// Gets or sets the account type id
        /// </summary>
        /// <value>
        /// The account type id.
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the account type name
        /// </summary>
        /// <value>
        /// The account type name
        /// </value>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the account type description
        /// </summary>
        /// <value>
        /// The account type description
        /// </value>
        public string Description { get; set; }
        
        /// <summary>
        /// Gets or sets the collection of accounts 
        /// </summary>
        /// <value>
        /// The accounts collection
        /// </value>
        public virtual ICollection<Account> Accounts { get; set; }
    }
}