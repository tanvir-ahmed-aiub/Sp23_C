namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderTableandFKPKProductCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "CId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "CId");
            AddForeignKey("dbo.Products", "CId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CId" });
            DropColumn("dbo.Products", "CId");
            DropTable("dbo.Orders");
        }
    }
}
