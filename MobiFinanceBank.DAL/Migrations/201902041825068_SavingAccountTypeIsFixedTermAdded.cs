namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SavingAccountTypeIsFixedTermAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SavingAccountType", "IsFixedTerm", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SavingAccountType", "IsFixedTerm");
        }
    }
}
