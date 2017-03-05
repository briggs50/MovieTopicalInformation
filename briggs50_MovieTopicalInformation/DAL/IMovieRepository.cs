using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> SelectAll();
        Movie SelectOne(int id);
        void Insert(Movie movie);
        void Update(Movie movie);
        void Delete(int id);
    }
}