namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class leave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        num_allowed_max = c.Int(nullable: false),
                        num_allowed_year = c.Int(nullable: false),
                        num_taken = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.Leaves");
        }
    }
}
