namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserOrderPkFk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 10),
                        Name = c.String(nullable: false, maxLength: 100),
                        Type = c.String(nullable: false, maxLength: 10),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
            AddColumn("dbo.Orders", "OrderedById", c => c.String(maxLength: 10));
            CreateIndex("dbo.Orders", "OrderedById");
            AddForeignKey("dbo.Orders", "OrderedById", "dbo.Users", "Username");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "OrderedById", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "OrderedById" });
            DropColumn("dbo.Orders", "OrderedById");
            DropTable("dbo.Users");
        }
    }
}
