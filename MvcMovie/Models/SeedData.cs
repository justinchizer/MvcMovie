using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Ocean's Eleven",
                         ReleaseDate = DateTime.Parse("2001-12-7"),
                         Genre = "Thriller",
                         Rating = "PG-13",
                         Price = 2.99M
                     },

                     new Movie
                     {
                         Title = "The Bourne Identity",
                         ReleaseDate = DateTime.Parse("2002-6-14"),
                         Genre = "Action",
                         Rating = "PG-13",
                         Price = 2.99M
                     },

                     new Movie
                     {
                         Title = "The Dark Knight",
                         ReleaseDate = DateTime.Parse("2008-7-18"),
                         Genre = "Action",
                         Rating = "PG-13",
                         Price = 2.99M
                     },

                   new Movie
                   {
                       Title = "Inception",
                       ReleaseDate = DateTime.Parse("2010-7-16"),
                       Genre = "Action",
                       Rating = "PG-13",
                       Price = 2.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}