namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PKFKOrderProductOrderdetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        PId = c.Int(nullable: false),
                        OId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.PId, cascadeDelete: true)
                .Index(t => t.PId)
                .Index(t => t.OId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "PId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OId", "dbo.Orders");
            DropIndex("dbo.OrderDetails", new[] { "OId" });
            DropIndex("dbo.OrderDetails", new[] { "PId" });
            DropTable("dbo.OrderDetails");
        }
    }
}
