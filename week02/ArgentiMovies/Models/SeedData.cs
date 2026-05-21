using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace ArgentiMovies.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<
              DbContextOptions<MvcMovieContext>>()))
      {
        // Look for any movies.
        if (context.Movie.Any())
        {
          return;   // DB has been seeded
        }
        context.Movie.AddRange(
            new Movie
            {
              Title = "Iron Man",
              ReleaseDate = DateTime.Parse("2008-2-5"),
              Genre = "Action",
              Rating = "R",
              Price = 150M
            },
            new Movie
            {
              Title = "The Incredible Hulk",
              ReleaseDate = DateTime.Parse("2008-6-13"),
              Genre = "Action",
              Rating = "R",
              Price = 150M
            },
            new Movie
            {
              Title = "Iron Man 2",
              ReleaseDate = DateTime.Parse("2010-7-5"),
              Genre = "Action",
              Rating = "R",
              Price = 170M
            },
            new Movie
            {
              Title = "Thor",
              ReleaseDate = DateTime.Parse("2011-6-5"),
              Genre = "Action",
              Rating = "R",
              Price = 150M
            }
        );
        context.SaveChanges();
      }
    }
  }
}