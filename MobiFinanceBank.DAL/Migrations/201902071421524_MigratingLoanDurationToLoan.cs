namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigratingLoanDurationToLoan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loan", "LoanDuration", c => c.Int(nullable: false));
            DropColumn("dbo.LoanType", "LoanDuration");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoanType", "LoanDuration", c => c.Int(nullable: false));
            DropColumn("dbo.Loan", "LoanDuration");
        }
    }
}
