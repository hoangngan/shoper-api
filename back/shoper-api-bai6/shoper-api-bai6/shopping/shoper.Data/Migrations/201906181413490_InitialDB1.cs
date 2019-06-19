namespace shoper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductQuantities",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        SizeId = c.Int(nullable: false),
                        ColorId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.SizeId, t.ColorId })
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.SizeId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.SizeId)
                .Index(t => t.ColorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductQuantities", "SizeId", "dbo.Sizes");
            DropForeignKey("dbo.ProductQuantities", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductQuantities", "ColorId", "dbo.Colors");
            DropIndex("dbo.ProductQuantities", new[] { "ColorId" });
            DropIndex("dbo.ProductQuantities", new[] { "SizeId" });
            DropIndex("dbo.ProductQuantities", new[] { "ProductId" });
            DropTable("dbo.ProductQuantities");
        }
    }
}
