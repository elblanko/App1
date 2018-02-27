namespace MVC1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        IdProduct = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Single(nullable: false),
                        LastBuy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduct);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
