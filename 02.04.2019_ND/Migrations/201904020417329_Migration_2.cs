namespace _02._04._2019_ND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
