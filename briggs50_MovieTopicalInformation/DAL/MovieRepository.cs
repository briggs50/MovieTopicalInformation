using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public class MovieRepository : IMovieRepository, IDisposable
    {
        private IEnumerable<Movie> movies;

        // when we create this object fill breweries with
        public MovieRepository()
        {
            movies = (IEnumerable<Movie>)HttpContext.Current.Session["movies"];
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            movies = null;
        }

        public void Insert(Movie movie)
        {
            throw new NotImplementedException();
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

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}