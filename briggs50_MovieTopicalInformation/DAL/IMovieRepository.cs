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

        // no matter what persistence is i want it to grab one from brewery
        // grab one using the id
        Movie SelectOne(int id);

        // to add a record, need all of the stuff
        void Insert(Movie movie);

        // updating, don't know what field so we need all the brewery to do an update
        void Update(Movie movie);

        // deleting one I just need the id
        void Delete(int id);
    }
}