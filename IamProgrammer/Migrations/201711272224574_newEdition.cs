namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newEdition : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Reports", newName: "ReportModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ReportModels", newName: "Reports");
        }
    }
}
