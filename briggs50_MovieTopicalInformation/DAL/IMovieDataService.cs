using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.DAL
{
    public interface IMovieDataService
    {
        List<Movie> Read();

        void Write(List<Movie> Movies);
    }
}