namespace VidlyASP2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres VALUES (2,'Action')");
            Sql("INSERT INTO Genres VALUES (3,'Drama')");
            Sql("INSERT INTO Genres VALUES (4,'Lolki')");
        }
        
        public override void Down()
        {
        }
    }
}
