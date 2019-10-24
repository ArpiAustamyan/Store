namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders");
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Orders", new[] { "Id", "BranchId" });
            AddForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders", new[] { "Id", "BranchId" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders");
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Orders", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", new[] { "Id", "BranchId" });
            AddForeignKey("dbo.OrderProducts", new[] { "OrderId", "BranchId" }, "dbo.Orders", new[] { "Id", "BranchId" }, cascadeDelete: true);
        }
    }
}
