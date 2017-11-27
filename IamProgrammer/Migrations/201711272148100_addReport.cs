namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReport : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CountSupporter = c.Int(nullable: false),
                        Genders = c.String(),
                        Hire = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.supporter", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.supporter", "Date");
            DropTable("dbo.Reports");
        }
    }
}
