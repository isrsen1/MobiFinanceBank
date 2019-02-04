namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoanType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LoanDuration = c.Int(nullable: false),
                        InterestRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoanType");
        }
    }
}
