using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public class MovieRepository : IMovieRepository, IDisposable
    {

        private IList<Movie> movies;

        public MovieRepository()
        {
            movies = HttpContext.Current.Session["Movies"] as IList<Movie>;
        }

        public IEnumerable<Movie> SelectAll()
        {
            return movies;
        }

        public Movie SelectOne(int id)
        {
            Movie selectedMovie = movies.Where(p => p.Id == id).FirstOrDefault();

            return selectedMovie;
        }

        public void Insert(Movie movie)
        {
            movies.Add(movie);
        }

        public void Update(Movie UpdateMovie)
        {
            var oldMovie = movies.Where(b => b.Id == UpdateMovie.Id).FirstOrDefault();

            if (oldMovie != null)
            {
                movies.Remove(oldMovie);
                movies.Add(UpdateMovie);
            }
        }

        public void Delete(int id)
        {
            var movie = movies.Where(b => b.Id == id).FirstOrDefault();
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }

        public void Save()
        {

        }

        public void Dispose()
        {
            movies = null;
        }
    }
}