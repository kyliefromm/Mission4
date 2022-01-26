using System;
using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options)
        {

        }
        public DbSet<MovieForm> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    MovieID = 1,
                    Category = "Action",
                    Title = "Spider Man No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = " ",
                    Notes = "Love this show so much!"
                },
                new MovieForm
                {
                    MovieID = 2,
                    Category = "Romantic Comedy",
                    Title = "Hitch",
                    Year = 2005,
                    Director = "Andy Tennant",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = " ",
                    Notes = "Love this show so much!"
                },
                new MovieForm
                {
                    MovieID = 3,
                    Category = "Drama/Musical",
                    Title = "In the Heights",
                    Year = 2021,
                    Director = "Jon M. Chu",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = " ",
                    Notes = "Love this show so much!"
                }

             ); 
        }
    }
}
