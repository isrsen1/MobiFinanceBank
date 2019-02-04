namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountToSavingOptional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SavingAccount", new[] { "AccountId" });
            AlterColumn("dbo.SavingAccount", "AccountId", c => c.Int());
            CreateIndex("dbo.SavingAccount", "AccountId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SavingAccount", new[] { "AccountId" });
            AlterColumn("dbo.SavingAccount", "AccountId", c => c.Int(nullable: false));
            CreateIndex("dbo.SavingAccount", "AccountId");
        }
    }
}
