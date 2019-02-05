using System.Data.Entity.Migrations;

namespace MobiFinanceBank.DAL.Migrations
{
    /// <summary>
    /// Account to saving optional - adding zero to many relationship 
    /// </summary>
    /// <seealso cref="DbMigration"/>
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
