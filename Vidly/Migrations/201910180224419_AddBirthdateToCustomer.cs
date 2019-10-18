namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Birthdate");
        }
    }
}
