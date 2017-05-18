namespace Rental_Application.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedacolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Remarks");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Remarks", c => c.String());
        }
    }
}
