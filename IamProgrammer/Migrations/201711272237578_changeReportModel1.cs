namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeReportModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "ReadyForHire", c => c.Int(nullable: false));
            AddColumn("dbo.Reports", "IsWorking", c => c.Int(nullable: false));
            DropColumn("dbo.Reports", "Hire");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reports", "Hire", c => c.String());
            DropColumn("dbo.Reports", "IsWorking");
            DropColumn("dbo.Reports", "ReadyForHire");
        }
    }
}
