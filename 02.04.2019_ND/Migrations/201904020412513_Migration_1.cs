namespace _02._04._2019_ND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Productname", c => c.String());
            AddColumn("dbo.Products", "SupplierID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "QuantityPerUnit", c => c.String());
            AddColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "UnitsInStock", c => c.Short(nullable: false));
            AddColumn("dbo.Products", "UnitsOnOrder", c => c.Short(nullable: false));
            AddColumn("dbo.Products", "RecorderLevel", c => c.Short(nullable: false));
            AddColumn("dbo.Products", "Discontinued", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Discontinued");
            DropColumn("dbo.Products", "RecorderLevel");
            DropColumn("dbo.Products", "UnitsOnOrder");
            DropColumn("dbo.Products", "UnitsInStock");
            DropColumn("dbo.Products", "UnitPrice");
            DropColumn("dbo.Products", "QuantityPerUnit");
            DropColumn("dbo.Products", "CategoryID");
            DropColumn("dbo.Products", "SupplierID");
            DropColumn("dbo.Products", "Productname");
        }
    }
}
