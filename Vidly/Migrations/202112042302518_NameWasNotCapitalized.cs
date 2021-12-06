namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameWasNotCapitalized : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "name");
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
