namespace VidlyMy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesToTable : DbMigration
    {
        public override void Up()
        {
            /*Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(1,1,1,02.01.1900 0:00:00,02.01.1900 0:00:00,1)");
            Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(2,2,2,02.01.1900 0:00:00,02.01.1900 0:00:00,2)");
            Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(3,3,3,02.01.1900 0:00:00,02.01.1900 0:00:00,3)");
            Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(4,4,4,02.01.1900 0:00:00,02.01.1900 0:00:00,4)");
            Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(5,5,5,02.01.1900 0:00:00,02.01.1900 0:00:00,5)");
            Sql("INSERT INTO Genres(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) Values(6,6,1,02.01.1900 0:00:00,02.01.1900 0:00:00,6)");
            */
        }
        public override void Down()
        {
        }
    }
}
