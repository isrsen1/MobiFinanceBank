namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SavingAccountType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SavingAccountType", "IsForeignCurrency", c => c.Boolean(nullable: false));
            AddColumn("dbo.SavingAccountType", "Currency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SavingAccountType", "Currency");
            DropColumn("dbo.SavingAccountType", "IsForeignCurrency");
        }
    }
}
