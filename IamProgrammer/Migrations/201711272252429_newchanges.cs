namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.supporter", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.supporter", "Date", c => c.DateTime(nullable: false));
        }
    }
}
