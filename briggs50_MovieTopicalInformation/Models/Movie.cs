using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public string LeadingActor { get; set; }
        public string Director { get; set; }
    }
}