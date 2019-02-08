namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanForeignToType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loan", "LoanTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Loan", "LoanTypeId");
            AddForeignKey("dbo.Loan", "LoanTypeId", "dbo.LoanType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Loan", "LoanTypeId", "dbo.LoanType");
            DropIndex("dbo.Loan", new[] { "LoanTypeId" });
            DropColumn("dbo.Loan", "LoanTypeId");
        }
    }
}
