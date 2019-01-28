namespace MobiFinanceBank.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Saving account type database model class.
    /// </summary>
    [Table("SavingAccountType")]
    public partial class SavingAccountType
    {
        /// <summary>
        /// Initializes new saving account type
        /// </summary>
        public SavingAccountType()
        {
            SavingAccounts = new HashSet<SavingAccount>();
        }

        /// <summary>
        /// Gets or sets saving account type id
        /// </summary>
        /// <value>
        /// Saving account type id
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets saving account type name
        /// </summary>
        /// <value>
        /// Saving account type name
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets saving account type effective interest rate
        /// </summary>
        /// <value>
        /// Effective interest rate
        /// </value>
        public double EffectiveInterestRate { get; set; }

        /// <summary>
        /// Gets or sets saving accounts
        /// </summary>
        /// <value>
        /// Saving accounts collection
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
