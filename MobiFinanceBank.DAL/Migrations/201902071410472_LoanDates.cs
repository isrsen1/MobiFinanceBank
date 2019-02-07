namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanDates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loan", "LoanStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Loan", "LoanEndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loan", "LoanEndDate");
            DropColumn("dbo.Loan", "LoanStartDate");
        }
    }
}
