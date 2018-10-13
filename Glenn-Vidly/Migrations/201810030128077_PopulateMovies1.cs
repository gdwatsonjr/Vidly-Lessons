namespace Glenn_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES (1, 'Hang Over', 5, '10/1/2018', '3/13/2005', 15,10)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES (2, 'Die Hard', 1, '10/1/2018', '5/15/1995', 15,10)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES (3, 'Terminator', 1, '10/1/2018', '8/13/1985', 15,10)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES (4, 'Toy Story', 3, '10/1/2018', '10/13/2005', 15,10)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock, NumberAvailable) VALUES (5, 'Titantic', 4, '10/1/2018', '12/13/1990', 15,10)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }

        public override void Down()
        {
        }
    }
}
