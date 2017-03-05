using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public class MovieRepository : IMovieRepository, IDisposable
    {

        private List<Movie> _movies;

        public MovieRepository()
        {
            MovieXMLDataService movieXmlDataService = new MovieXMLDataService();

            using (movieXmlDataService)
            {
                _movies = movieXmlDataService.Read() as List<Movie>;
            }
        }


        public IEnumerable<Movie> SelectAll()
        {
            return _movies;
        }

        public Movie SelectOne(int id)
        {
            //Brewery selectedBrewery =
            //(from brewery in _breweries
            // where brewery.Id == id
            // select brewery).FirstOrDefault();

            Movie selectedMovie = _movies.Where(p => p.Id == id).FirstOrDefault();

            return selectedMovie;
        }

        public void Insert(Movie movie)
        {
            _movies.Add(movie);

            Save();
        }

        public void Update(Movie UpdateMovie)
        {
            var oldMovie = _movies.Where(b => b.Id == UpdateMovie.Id).FirstOrDefault();

            if (oldMovie != null)
            {
                _movies.Remove(oldMovie);
                _movies.Add(UpdateMovie);
            }

            Save();
        }
        public void Delete(int id)
        {
            var movie = _movies.Where(b => b.Id == id).FirstOrDefault();

            if (movie != null)
            {
                _movies.Remove(movie);
            }

            Save();
        }

        public void Save()
        {
            MovieXMLDataService breweryXmlDataService = new MovieXMLDataService();

            using (breweryXmlDataService)
            {
                breweryXmlDataService.Write(_movies);
            }
        }

        public void Dispose()
        {
            _movies = null;
        }
    }
}