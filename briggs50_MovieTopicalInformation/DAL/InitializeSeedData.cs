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
                MoviePoster = "Images/americansniper150x223.jpg"
            });

            movies.Add(new Movie
            {
                Id = 2,
                Title = "The Princess Bride",
                Year = 1987,
                Category = "Fantasy",
                LeadingActor = "Cary Elwes",
                Director = "Rob Reiner",
                MoviePoster = "Images/theprincessbride150x225.jpg"
            });

            movies.Add(new Movie
            {
                Id = 3,
                Title = "10 Things I Hate About You",
                Year = 1999,
                Category = "Comedy",
                LeadingActor = "Heath Ledger",
                Director = "Gil Junger",
                MoviePoster = "Images/tenthings150x225.jpg"
            });

            movies.Add(new Movie
            {
                Id = 4,
                Title = "The Little Mermaid",
                Year = 1989,
                Category = "Animation",
                LeadingActor = "Jodi Benson",
                Director = "Ron Clements",
                MoviePoster = "Images/thelittlemermaid150x218.jpg"
            });

            movies.Add(new Movie
            {
                Id = 5,
                Title = "The Hidden Figures",
                Year = 2016,
                Category = "Biography",
                LeadingActor = "Teraji P. Henson",
                Director = "Theodore Melfi",
                MoviePoster = "Images/hiddenfigures150x286.jpg"
            });

            return movies;
        }
    }
}