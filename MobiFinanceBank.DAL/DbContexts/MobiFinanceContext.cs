﻿using MobiFinanceBank.DAL.DbContexts.Interfaces;

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
        public MobiFinanceContext()
            : base("name=MobiFinanceContext")
        {
        }

        public virtual DbSet<BalanceSheet> BalanceSheets { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Liability> Liabilities { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BalanceSheet>()
                .HasMany(e => e.Assets)
                .WithRequired(e => e.BalanceSheet)
                .HasForeignKey(e => e.BalanceSheetId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<BalanceSheet>()
                .HasMany(e => e.Liabilities)
                .WithRequired(e => e.BalanceSheet)
                .HasForeignKey(e => e.BalanceSheetId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Asset>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Asset>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Liability>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Liability>()
                .Property(e => e.LiabilityType)
                .IsUnicode(false);

            modelBuilder.Entity<Liability>()
                .Property(e => e.Category)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.LastName)
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
                .Property(e => e.ClientType)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BalanceSheets)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete();

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
                .Property(e => e.LoanName)
                .IsUnicode(false);

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
                .Property(e => e.Password)
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
        }
    }
}