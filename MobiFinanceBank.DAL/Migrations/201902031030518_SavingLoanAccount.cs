using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Saving loan account migration - adding necessary attributes to saving account, account and loan tables
    /// </summary>
    /// <seealso cref="DbMigration"/>
    public partial class SavingLoanAccount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "EmployeeId", c => c.Int(nullable: false));
            AddColumn("dbo.AccountType", "NegativeBalanceLimit", c => c.Double(nullable: false));
            AddColumn("dbo.AccountType", "IncomeBottomLimit", c => c.Double(nullable: false));
            AddColumn("dbo.AccountType", "NegativeBalanceMonthlyFee", c => c.Double(nullable: false));
            AddColumn("dbo.Loan", "Capital", c => c.Double(nullable: false));
            AddColumn("dbo.Loan", "IsStandingOrderActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Loan", "AccountId", c => c.Int());
            AddColumn("dbo.SavingAccount", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.SavingAccount", "Capital", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccount", "Balance", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccount", "FixedTermDepositingStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SavingAccount", "FixedTermDepositingEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SavingAccount", "IsStandingOrderActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.SavingAccount", "AccountId", c => c.Int(nullable: false));
            AddColumn("dbo.SavingAccountType", "InterestRate", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccountType", "FixedTermDepositingPeriod", c => c.Int(nullable: false));
            AlterColumn("dbo.Account", "Blocked", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Account", "EmployeeId");
            CreateIndex("dbo.Loan", "AccountId");
            CreateIndex("dbo.SavingAccount", "AccountId");
            AddForeignKey("dbo.Account", "EmployeeId", "dbo.Employee", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Loan", "AccountId", "dbo.Account", "Id");
            AddForeignKey("dbo.SavingAccount", "AccountId", "dbo.Account", "Id");
            DropColumn("dbo.Account", "DozvoljeniMinus");
            DropColumn("dbo.Loan", "StartDate");
            DropColumn("dbo.Loan", "Glavnica");
            DropColumn("dbo.Loan", "RokOtplate");
            DropColumn("dbo.Loan", "KamatnaStopa");
            DropColumn("dbo.Loan", "LoanName");
            DropColumn("dbo.SavingAccount", "Status");
            DropColumn("dbo.SavingAccount", "Glavnica");
            DropColumn("dbo.SavingAccount", "RokOročenja");
            DropColumn("dbo.SavingAccount", "KonačanIznos");
            DropColumn("dbo.SavingAccount", "Interest");
            DropColumn("dbo.SavingAccount", "RKS");
            DropColumn("dbo.SavingAccountType", "EffectiveInterestRate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SavingAccountType", "EffectiveInterestRate", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccount", "RKS", c => c.Double());
            AddColumn("dbo.SavingAccount", "Interest", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccount", "KonačanIznos", c => c.Double());
            AddColumn("dbo.SavingAccount", "RokOročenja", c => c.Int(nullable: false));
            AddColumn("dbo.SavingAccount", "Glavnica", c => c.Double(nullable: false));
            AddColumn("dbo.SavingAccount", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Loan", "LoanName", c => c.String(unicode: false));
            AddColumn("dbo.Loan", "KamatnaStopa", c => c.Double(nullable: false));
            AddColumn("dbo.Loan", "RokOtplate", c => c.Int(nullable: false));
            AddColumn("dbo.Loan", "Glavnica", c => c.Double(nullable: false));
            AddColumn("dbo.Loan", "StartDate", c => c.DateTime(storeType: "date"));
            AddColumn("dbo.Account", "DozvoljeniMinus", c => c.Double());
            DropForeignKey("dbo.SavingAccount", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Loan", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Account", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.SavingAccount", new[] { "AccountId" });
            DropIndex("dbo.Loan", new[] { "AccountId" });
            DropIndex("dbo.Account", new[] { "EmployeeId" });
            AlterColumn("dbo.Account", "Blocked", c => c.Int());
            DropColumn("dbo.SavingAccountType", "FixedTermDepositingPeriod");
            DropColumn("dbo.SavingAccountType", "InterestRate");
            DropColumn("dbo.SavingAccount", "AccountId");
            DropColumn("dbo.SavingAccount", "IsStandingOrderActive");
            DropColumn("dbo.SavingAccount", "FixedTermDepositingEndDate");
            DropColumn("dbo.SavingAccount", "FixedTermDepositingStartDate");
            DropColumn("dbo.SavingAccount", "Balance");
            DropColumn("dbo.SavingAccount", "Capital");
            DropColumn("dbo.SavingAccount", "IsActive");
            DropColumn("dbo.Loan", "AccountId");
            DropColumn("dbo.Loan", "IsStandingOrderActive");
            DropColumn("dbo.Loan", "Capital");
            DropColumn("dbo.AccountType", "NegativeBalanceMonthlyFee");
            DropColumn("dbo.AccountType", "IncomeBottomLimit");
            DropColumn("dbo.AccountType", "NegativeBalanceLimit");
            DropColumn("dbo.Account", "EmployeeId");
        }
    }
}
