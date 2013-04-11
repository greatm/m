namespace m.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConveyanceMode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConveyanceModes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ConveyanceModes");
        }
    }
}
