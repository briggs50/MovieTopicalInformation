using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public static class InitializeSeedData
    {
        public static IEnumerable<Movie> GetAllMovies()
        {
            IList<Movie> movies = new List<Movie>();

            movies.Add(new Movie
            {
                Id = 1,
                Title = "American Sniper",
                Year = 2014,
                Category = "Action",
                LeadingActor = "Bradley Cooper",
                Director = "Clint Eastwood",
            });

            movies.Add(new Movie
            {
                Id = 2,
                Title = "The Princess Bride",
                Year = 1987,
                Category = "Fantasy",
                LeadingActor = "Cary Elwes",
                Director = "Rob Reiner",
            });

            movies.Add(new Movie
            {
                Id = 3,
                Title = "10 Things I Hate About You",
                Year = 1999,
                Category = "Comedy",
                LeadingActor = "Heath Ledger",
                Director = "Gil Junger",
            });

            movies.Add(new Movie
            {
                Id = 4,
                Title = "The Little Mermaid",
                Year = 1989,
                Category = "Animation",
                LeadingActor = "Jodi Benson",
                Director = "Clint Eastwood",
            });

            movies.Add(new Movie
            {
                Id = 5,
                Title = "The Hidden Figures",
                Year = 2016,
                Category = "Biography",
                LeadingActor = "Teraji P. Henson",
                Director = "Theodore Melfi",
            });

            return movies;
        }
    }
}