namespace _02._04._2019_ND.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mogration_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Title = c.String(),
                        TitleOfCourtesy = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        HirehDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        PostalCode = c.String(),
                        Country = c.String(),
                        HomePhone = c.String(),
                        Extension = c.String(),
                        Photo = c.Binary(),
                        Notes = c.String(),
                        ReportsTo = c.Int(),
                        PhotoPath = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Employees", t => t.ReportsTo)
                .Index(t => t.ReportsTo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ReportsTo", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "ReportsTo" });
            DropTable("dbo.Employees");
        }
    }
}
