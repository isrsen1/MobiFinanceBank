namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SavingAccountTypeValueTypeChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SavingAccountType", "IsFixedTerm", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SavingAccountType", "IsFixedTerm", c => c.Int(nullable: false));
        }
    }
}
