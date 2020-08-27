namespace MvcMovieApp.Migrations
{
    using MvcMovieApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovieApp.Models.MvcMovieAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovieApp.Models.MvcMovieAppContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Movies.AddOrUpdate(i => i.Title,
        new Movie
        {
            Title = "Tenet",
            ReleaseDate = DateTime.Parse("2020-2-07"),
            Genre = "Spy Thriller",
            Rating = "Hit",
            Price = 250M
        },

         new Movie
         {
             Title = "Black Widow ",
             ReleaseDate = DateTime.Parse("2020-3-11"),
             Genre = "Thriller",
             Rating = "Hit",
             Price = 300M
         },

         new Movie
         {
             Title = "Five Feet Apart",
             ReleaseDate = DateTime.Parse("2019-2-15"),
             Genre = "Romance",
             Rating = "Average",
             Price = 200M
         },

       new Movie
       {
           Title = "Dil Bechara",
           ReleaseDate = DateTime.Parse("2020-7-20"),
           Genre = "Romance",
           Rating = "Average",
           Price = 250M
       }
   );
        }
    }
}
