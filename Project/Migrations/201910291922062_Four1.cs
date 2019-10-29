namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Four1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "BranchId" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Orders", "BranchId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", new[] { "Id", "BranchId" });
            CreateIndex("dbo.Orders", "BranchId");
            AddForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders", new[] { "Id", "BranchId" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "BranchId" });
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "BranchId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", new[] { "Id", "BranchId" });
            CreateIndex("dbo.Orders", "BranchId");
            AddForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders", new[] { "Id", "BranchId" }, cascadeDelete: true);
        }
    }
}
