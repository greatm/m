namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class employee_grade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "GradeID", c => c.Int());
            AddForeignKey("dbo.Employees", "GradeID", "dbo.Grades", "ID");
            CreateIndex("dbo.Employees", "GradeID");
            DropColumn("dbo.Employees", "grade");
        }

        public override void Down()
        {
            AddColumn("dbo.Employees", "grade", c => c.String());
            DropIndex("dbo.Employees", new[] { "GradeID" });
            DropForeignKey("dbo.Employees", "GradeID", "dbo.Grades");
            DropColumn("dbo.Employees", "GradeID");
        }
    }
}
