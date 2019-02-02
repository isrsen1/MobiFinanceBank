using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Account database model class.
    /// </summary>
    [Table("Account")]
    public partial class Account
    {
        /// <summary>
        /// Gets or sets the account id
        /// </summary>
        /// <value>
        /// Account id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets IBAN
        /// </summary>
        /// <value>
        /// IBAN
        /// </value>
        public string IBAN { get; set; }

        /// <summary>
        /// Gets or sets the account card number
        /// </summary>
        /// <value>
        /// The card number
        /// </value>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the account balance
        /// </summary>
        /// <value>
        /// Account balance
        /// </value>
        public double Balance { get; set; }
        
        /// <summary>
        /// Gets or sets the value indicating whether the account is blocked
        /// </summary>
        /// <value>
        /// <c>true</c>if the account is blocked, otherwise <c>false</c>
        /// </value>
        public bool Blocked { get; set; }

        /// <summary>
        /// Gets or sets the account client
        /// </summary>
        /// <value>
        /// Account client
        /// </value>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the account type id
        /// </summary>
        /// <value>
        /// Account type id
        /// </value>
        public int AccountTypeId { get; set; }

        /// <summary>
        /// Gets or sets the employee id
        /// </summary>
        /// <value>
        /// Employee id
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the account owner
        /// </summary>
        /// <value>
        /// The account owner
        /// </value>
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets the account type
        /// </summary>
        /// <value>
        /// The account type
        /// </value>
        [ForeignKey("AccountTypeId")]
        public virtual AccountType AccountType { get; set; }

        /// <summary>
        /// Gets or sets employee who issued saving account
        /// </summary>
        /// <value>
        /// Employee
        /// </value>
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        /// <summary>
        /// Gets or sets collection of loans
        /// </summary>
        /// <value>
        /// Loans collection
        /// </value>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Gets or sets collection of saving accounts
        /// </summary>
        /// <value>
        /// Saving accounts collection
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
