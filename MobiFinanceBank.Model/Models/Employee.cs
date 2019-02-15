namespace MobiFinanceBank.Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Employee database model class.
    /// </summary>
    [Table("Employee")]
    public partial class Employee
    {
        /// <summary>
        /// Initializes new employee instance
        /// </summary>
        public Employee()
        {
            Loans = new HashSet<Loan>();
            SavingAccounts = new HashSet<SavingAccount>();
        }

        /// <summary>
        /// Gets or sets employee's id
        /// </summary>
        /// <value>
        /// Employee's id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets employee's first name
        /// </summary>
        /// <value>
        /// Employee's first name
        /// </value>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Gets or sets employee's last name
        /// </summary>
        /// <value>
        /// Employee's last name
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets OIB
        /// </summary>
        /// <value>
        /// Personal Identity Number
        /// </value>
        public int OIB { get; set; }
        /// <summary>
        /// Gets or sets employee's email
        /// </summary>
        /// <value>
        /// Employee's email 
        /// </value>
        public string Email { get; set; }
        
        /// <summary>
        /// Gets or sets employee's address
        /// </summary>
        /// <value>
        /// Employee's address
        /// </value>
        public string Address { get; set; }
         
        /// <summary>
        /// Gets or sets employee's phone number
        /// </summary>
        /// <value>
        /// Employee's phone number
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets employee's user name
        /// </summary>
        /// <value>
        /// Employee's user name
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets employee's type id 
        /// </summary>
        /// <value>
        /// Employee's type id
        /// </value>
        public int EmployeeTypeId { get; set; }
        /// <summary>
        /// Gets or sets employee's hash password ID
        /// </summary>
        /// <value>
        /// Employee's hash password ID
        /// </value>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// Gets or sets employee's password
        /// </summary>
        /// <value>
        /// Employee's password
        /// </value>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets employee's issued loans
        /// </summary>
        /// <value>
        /// Employee's issued loans
        /// </value>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Gets or sets employee's issued saving accounts
        /// </summary>
        /// <value>
        /// Employee's issued saving accounts
        /// </value>
        public virtual ICollection<SavingAccount> SavingAccounts { get; set; }
        /// <summary>
        /// Gets or sets employee's type
        /// </summary>
        /// <value>
        /// Employee's type
        /// </value>
        [ForeignKey("EmployeeTypeId")]
        public virtual EmployeeType EmployeeType { get; set; }
        
    }
}
