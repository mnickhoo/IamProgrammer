namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addReadyForHire : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.supporter", "ReadyForHire", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.supporter", "ReadyForHire");
        }
    }
}
