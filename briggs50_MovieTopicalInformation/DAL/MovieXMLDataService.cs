using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using briggs50_MovieTopicalInformation.Models;
using System.IO;
using System.Xml.Serialization;

namespace briggs50_MovieTopicalInformation.DAL
{
    public class MovieXMLDataService : IMovieDataService, IDisposable
    {
      
        public List<Movie> Read()
        {
            Movies moviesObject;

            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();
            StreamReader sReader = new StreamReader(xmlFilePath);

            // initialize an XML seriailizer object
            XmlSerializer deserializer = new XmlSerializer(typeof(Movies));

            using (sReader)
            {
                // deserialize the XML data set into a generic object
                object xmlObject = deserializer.Deserialize(sReader);

                // cast the generic object to the list class
                moviesObject = (Movies)xmlObject;
            }

            return moviesObject.movies;
        }

        public void Write(List<Movie> movies)
        {
            string xmlFilePath = HttpContext.Current.Application["dataFilePath"].ToString();
            StreamWriter sWriter = new StreamWriter(xmlFilePath, false);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("movies"));

            using (sWriter)
            {
                serializer.Serialize(sWriter, movies);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}