namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanTypeCurrency : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoanType", "IsForeignCurrency", c => c.Boolean(nullable: false));
            AddColumn("dbo.LoanType", "Currency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.LoanType", "Currency");
            DropColumn("dbo.LoanType", "IsForeignCurrency");
        }
    }
}
