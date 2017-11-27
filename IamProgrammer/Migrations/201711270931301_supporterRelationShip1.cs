namespace IamProgrammer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supporterRelationShip1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.supporter", "Skill_Id", "dbo.Skill");
            DropIndex("dbo.supporter", new[] { "Skill_Id" });
            RenameColumn(table: "dbo.supporter", name: "Skill_Id", newName: "skillId");
            AlterColumn("dbo.supporter", "skillId", c => c.Int(nullable: false));
            CreateIndex("dbo.supporter", "skillId");
            AddForeignKey("dbo.supporter", "skillId", "dbo.Skill", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.supporter", "skillId", "dbo.Skill");
            DropIndex("dbo.supporter", new[] { "skillId" });
            AlterColumn("dbo.supporter", "skillId", c => c.Int());
            RenameColumn(table: "dbo.supporter", name: "skillId", newName: "Skill_Id");
            CreateIndex("dbo.supporter", "Skill_Id");
            AddForeignKey("dbo.supporter", "Skill_Id", "dbo.Skill", "Id");
        }
    }
}
