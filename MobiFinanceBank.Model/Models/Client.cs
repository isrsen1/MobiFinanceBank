using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobiFinanceBank.Model.Models
{
    /// <summary>
    /// Client database model class.
    /// </summary>
    [Table("Client")]
    public partial class Client
    {
        /// <summary>
        /// Initializes new client instance
        /// </summary>
        public Client()
        {
            BalanceSheets = new HashSet<BalanceSheet>();
            Loans = new HashSet<Loan>();
            Accounts = new HashSet<Account>();
            SavingAccounts = new HashSet<SavingAccount>();
        }

        /// <summary>
        /// Gets or sets clients id
        /// </summary>
        /// <value>
        /// Clients id
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets clients first name
        /// </summary>
        /// Clients first name
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets clients last name
        /// </summary>
        /// <value>
        /// Clients last name
        /// </value>
        public string LastName { get; set; }
        
        /// <summary>
        /// Gets or sets clients personal identification number
        /// </summary>
        /// <value>
        /// Personal identification number
        /// </value>
        public string OIB { get; set; }
        
        /// <summary>
        /// Gets or sets clients email address
        /// </summary>
        /// <value>
        /// Clients email address
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets clients phone number
        /// </summary>
        /// <value>
        /// Clients phone number
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets clients income
        /// </summary>
        /// <value>
        /// Clients income
        /// </value>
        public double? Income { get; set; }
        
        /// <summary>
        /// Gets or sets clients type
        /// </summary>
        /// <value>
        /// Clients type
        /// </value>
        public string ClientType { get; set; }

        /// <summary>
        /// Gets or sets clients address
        /// </summary>
        /// Clients address
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets clients balance sheets
        /// </summary>
        /// Clients balance sheets collection
        public virtual ICollection<BalanceSheet> BalanceSheets { get; set; }

        /// <summary>
        /// Gets or sets clients loans 
        /// </summary>
        /// <value>
        /// Clients loans collection
        /// </value>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Gets or sets clients accounts
        /// </summary>
        /// <value>
        /// Clients accounts collection
        /// </value>
        public virtual ICollection<Account> Accounts { get; set; }

        /// <summary>
        /// Gets or sets clients saving accounts collection 
        /// </summary>
        /// <value>
        /// Clients saving accounts collection
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
    }
}
