namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientUpgraded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "IsEmployed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Client", "IsFixedTermContract", c => c.Boolean(nullable: false));
            AddColumn("dbo.Client", "IsUnusualProfession", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "IsUnusualProfession");
            DropColumn("dbo.Client", "IsFixedTermContract");
            DropColumn("dbo.Client", "IsEmployed");
        }
    }
}
