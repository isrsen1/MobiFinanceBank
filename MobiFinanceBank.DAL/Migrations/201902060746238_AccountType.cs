namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AccountType", "IsForeignCurrency", c => c.Boolean(nullable: false));
            AddColumn("dbo.AccountType", "Currency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AccountType", "Currency");
            DropColumn("dbo.AccountType", "IsForeignCurrency");
        }
    }
}
