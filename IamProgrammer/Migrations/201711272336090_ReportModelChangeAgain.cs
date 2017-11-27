namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReportModelChangeAgain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "Female", c => c.Int(nullable: false));
            AlterColumn("dbo.Reports", "Male", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "Male", c => c.String());
            AlterColumn("dbo.Reports", "Female", c => c.String());
        }
    }
}
