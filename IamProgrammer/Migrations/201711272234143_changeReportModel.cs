namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeReportModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ReportModels", newName: "Reports");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Reports", newName: "ReportModels");
        }
    }
}
