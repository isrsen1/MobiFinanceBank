using MobiFinanceBank.DAL.DbContexts.Interfaces;

namespace MobiFinanceBank.DAL.DbContexts
{
    using System.Data.Entity;
    using Model.Models;

    /// <summary>
    /// Mobi finance context
    /// </summary>
    /// <seealso cref="DbContext"/>
    public partial class MobiFinanceContext : DbContext, IMobiFinanceContext
    {
        /// <summary>
        /// Initializes new instance of mobi finance context
        /// </summary>
        public MobiFinanceContext()
            : base("name=MobiFinanceContext")
        {
        }
        
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<RepaymentPlan> RepaymentPlan { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<SavingAccountType> SavingAccountTypes { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual  DbSet<ClientType> ClientTypes { get; set; }
        public virtual DbSet<LoanType> LoanTypes { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.CompanyName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);
            
            modelBuilder.Entity<Client>()
                .Property(e => e.Address)
                .IsUnicode(false);
            
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Client>()
                .HasMany(e => e.SavingAccounts)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete();
            
            modelBuilder.Entity<Loan>()
                .HasMany(e => e.RepaymentPlans)
                .WithRequired(e => e.Loan)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Account>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.SavingAccounts)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.AccountId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.Loans)
                .WithOptional(e => e.Account)
                .HasForeignKey(e => e.AccountId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeType>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.EmployeeType)
                .HasForeignKey(e => e.EmployeeTypeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ClientType>()
                .HasMany(c => c.Clients)
                .WithRequired(c => c.ClientType)
                .HasForeignKey(c => c.ClientTypeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ClientType>()
                .Property(c => c.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AccountType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AccountType>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<AccountType>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.AccountType)
                .HasForeignKey(e => e.AccountTypeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SavingAccountType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<SavingAccountType>()
                .HasMany(e => e.SavingAccounts)
                .WithRequired(e => e.SavingAccountType)
                .HasForeignKey(e => e.SavingAccountTypeId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.PasswordHash)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.SavingAccounts)
                .WithRequired(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<LoanType>()
                .HasMany(e => e.Loans)
                .WithRequired(e => e.LoanType)
                .HasForeignKey(e => e.LoanTypeId)
                .WillCascadeOnDelete();
        }
    }
}
