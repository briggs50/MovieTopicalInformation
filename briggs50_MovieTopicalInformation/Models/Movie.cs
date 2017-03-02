using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace briggs50_MovieTopicalInformation.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }        
        public int Year { get; set; }
        public string Category { get; set; }
        public string LeadingActor { get; set; }
        public string Director { get; set; }

        public string MoviePoster { get; set; }
    }
}