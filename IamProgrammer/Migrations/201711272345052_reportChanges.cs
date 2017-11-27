namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reportChanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reports", "NoneGender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reports", "NoneGender", c => c.String());
        }
    }
}
