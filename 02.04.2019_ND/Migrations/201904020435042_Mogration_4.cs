namespace _02._04._2019_ND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mogration_4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Photo", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Photo", c => c.Binary());
        }
    }
}
