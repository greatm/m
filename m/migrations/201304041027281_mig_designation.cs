namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class mig_designation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Designation_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Designations", t => t.Designation_ID)
                .Index(t => t.Designation_ID);

        }

        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Designation_ID" });
            DropForeignKey("dbo.Employees", "Designation_ID", "dbo.Designations");
            DropTable("dbo.Employees");
            DropTable("dbo.Designations");
        }
    }
}