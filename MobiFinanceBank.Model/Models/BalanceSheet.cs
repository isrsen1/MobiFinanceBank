using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Balance sheet database model class.
    /// </summary>
    [Table("BalanceSheet")]
    public partial class BalanceSheet
    {
        /// <summary>
        /// Initializes new instance of balance sheet
        /// </summary>
        public BalanceSheet()
        {
            Assets = new HashSet<Asset>();
            Liabilities = new HashSet<Liability>();
        }

        /// <summary>
        /// Gets or sets the balance sheet id
        /// </summary>
        /// <value>
        /// The balance sheet id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the balance sheet year
        /// </summary>
        /// <value>
        /// The balance sheet year
        /// </value>
        public int BalanceSheetYear { get; set; }

        /// <summary>
        /// Gets or sets the client id
        /// </summary>
        /// <value>
        /// The client id
        /// </value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the balance sheet client
        /// </summary>
        /// <value>
        /// The balance sheet client
        /// </value>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        
        /// <summary>
        /// Gets or sets the balance sheet collection of assets
        /// </summary>
        /// <value>
        /// The balance sheet collection of assets
        /// </value>
        public virtual ICollection<Asset> Assets { get; set; }
        
        /// <summary>
        /// Gets or sets the balance sheet collection of liabilities
        /// </summary>
        /// <value>
        /// The balance sheet collection of liabilities
        /// </value>
        public virtual ICollection<Liability> Liabilities { get; set; }
    }
}
