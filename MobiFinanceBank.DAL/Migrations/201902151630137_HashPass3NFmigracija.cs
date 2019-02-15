namespace MobiFinanceBank.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HashPass3NFmigracija : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.HashedPassword");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.HashedPassword",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hash = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
