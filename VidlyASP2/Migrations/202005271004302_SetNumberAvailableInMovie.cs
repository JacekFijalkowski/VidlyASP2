namespace VidlyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNumberAvailableInMovie : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = InStock");
        }
        
        public override void Down()
        {
        }
    }
}
