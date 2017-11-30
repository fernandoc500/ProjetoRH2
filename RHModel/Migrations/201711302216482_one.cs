namespace RHModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class one : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Cargo", new[] { "CargoPaiId" });
            DropIndex("dbo.Empregado", new[] { "SuperiorId" });
            AlterColumn("dbo.Cargo", "CargoPaiId", c => c.Int());
            AlterColumn("dbo.Empregado", "SuperiorId", c => c.Int());
            CreateIndex("dbo.Cargo", "CargoPaiId");
            CreateIndex("dbo.Empregado", "SuperiorId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Empregado", new[] { "SuperiorId" });
            DropIndex("dbo.Cargo", new[] { "CargoPaiId" });
            AlterColumn("dbo.Empregado", "SuperiorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Cargo", "CargoPaiId", c => c.Int(nullable: false));
            CreateIndex("dbo.Empregado", "SuperiorId");
            CreateIndex("dbo.Cargo", "CargoPaiId");
        }
    }
}
