namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectManagerID = c.Int(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.ProjectManagerID)
                .Index(t => t.ProjectManagerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Mobile = c.String(),
                        eMail = c.String(),
                        DesignationID = c.Int(),
                        Father = c.String(),
                        Mother = c.String(),
                        DoB = c.DateTime(nullable: false),
                        sex = c.String(),
                        marrital_status = c.String(),
                        DoJ = c.DateTime(),
                        DoJA = c.DateTime(),
                        DoI = c.DateTime(),
                        DoSalary = c.DateTime(),
                        DoL = c.DateTime(),
                        reason_leave = c.String(),
                        category = c.String(),
                        division = c.String(),
                        department = c.String(),
                        grade = c.String(),
                        Bank = c.String(),
                        bank_account = c.String(),
                        pf_no = c.String(),
                        pf_no_dept = c.String(),
                        esi_no = c.String(),
                        esi_dispensary = c.String(),
                        restrict_pf_contri = c.Boolean(),
                        zero_pension = c.Boolean(),
                        zero_pt = c.Boolean(),
                        PAN = c.String(),
                        Ward = c.String(),
                        AddressPresent = c.String(),
                        AddressPermanent = c.String(),
                        Remarks = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Designations", t => t.DesignationID)
                .Index(t => t.DesignationID);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "DesignationID" });
            DropIndex("dbo.Projects", new[] { "ProjectManagerID" });
            DropForeignKey("dbo.Employees", "DesignationID", "dbo.Designations");
            DropForeignKey("dbo.Projects", "ProjectManagerID", "dbo.Employees");
            DropTable("dbo.Designations");
            DropTable("dbo.Employees");
            DropTable("dbo.Projects");
            DropTable("dbo.Clients");
        }
    }
}
