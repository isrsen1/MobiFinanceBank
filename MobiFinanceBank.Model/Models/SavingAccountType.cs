namespace MobiFinanceBank.Model.Models
{
    using System.Collections.Generic;
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
        /// Gets or sets the value indicating if account is in foreign currency
        /// </summary>
        /// <value>
        /// <c>true</c> if account is in foreign currency, otherwise <c>false</c>
        /// </value>
        public bool IsForeignCurrency { get; set; }

        /// <summary>
        /// Gets or sets the currency
        /// </summary>
        /// <value>
        /// The currency
        /// </value>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets saving account interest
        /// </summary>
        /// <value>
        /// Saving account interest
        /// </value>
        public double InterestRate { get; set; }

        /// <summary>
        /// Gets or sets the fixed term depositing period - unit - year
        /// </summary>
        /// <value>
        /// Gets or sets the fixed term depositing period
        ///</value>
        public int FixedTermDepositingPeriod { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether this saving account type is fixed term
        /// </summary>
        /// <value>
        /// <c>true</c> if this saving account type is fixed term, otherwise <c>false</c>
        /// </value>
        public bool IsFixedTerm { get; set; }

        /// <summary>
        /// Gets or sets saving accounts
        /// </summary>
        /// <value>
        /// Saving accounts collection
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
