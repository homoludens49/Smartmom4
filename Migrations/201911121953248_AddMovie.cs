namespace Smartmom4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (1, 'Hangover', 5, 1980-04-25, 1979-04-25, 2) SET IDENTITY_INSERT Movies OFF");
            Sql("SET IDENTITY_INSERT Movies ON INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES (2, 'Die Hard', 1, 1980-04-25, 1979-04-25, 2) SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
