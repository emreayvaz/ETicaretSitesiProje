namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0406 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cities", "Name", c => c.Int(nullable: false));
        }
    }
}
