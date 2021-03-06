﻿using briggs50_MovieTopicalInformation.DAL;
using briggs50_MovieTopicalInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace briggs50_MovieTopicalInformation.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        [HttpGet]
        public ActionResult Index(string sortOrder)
        {
            MovieRepository movieRepository = new MovieRepository();

            ViewBag.Category = ListofCategories();

            IEnumerable<Movie> movies = null;

            using (movieRepository)
            {
                movies = movieRepository.SelectAll() as IList<Movie>;
            }

            switch (sortOrder)
            {
                case "Title":
                    movies = movies.OrderBy(b => b.Title);
                    break;
                case "Year":
                    movies = movies.OrderBy(b => b.Year);
                    break;
                case "Category":
                    movies = movies.OrderBy(b => b.Category);
                    break;
                case "Leading Actor":
                    movies = movies.OrderBy(b => b.LeadingActor);
                    break;
                case "Director":
                    movies = movies.OrderBy(b => b.Director);
                    break;
                default:
                    movies = movies.OrderBy(b => b.Title);
                    break;
            }

            return View(movies);
        }

        [HttpPost]
        public ActionResult Index(string searchCriteria, string categoryFilter)
        {

            MovieRepository movieRepository = new MovieRepository();

            ViewBag.Category = ListofCategories();

            IEnumerable<Movie> movies;

            using (movieRepository)
            {
                movies = movieRepository.SelectAll() as IList<Movie>;
            }

            if (searchCriteria != null)
            {
                movies = movies.Where(movie => movie.Title.ToUpper().Contains(searchCriteria.ToUpper()));
            }

            if (categoryFilter != "" || categoryFilter == null)
            {
                movies = movies.Where(movie => movie.Category == categoryFilter);
            }

            return View(movies);
        }

        [NonAction]
        private IEnumerable<string> ListofCategories()
        {
            MovieRepository movieRepository = new MovieRepository();

            IEnumerable<Movie> movies;
            using (movieRepository)
            {
                movies = movieRepository.SelectAll() as IList<Movie>;
            }

            var categories = movies.Select(movie => movie.Category).Distinct().OrderBy(x => x);

            return categories;
        }
        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            MovieRepository movieRepository = new MovieRepository();
            Movie movie = new Movie();

            using (movieRepository)
            {
                movie = movieRepository.SelectOne(id);
            }

            return View(movie);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                MovieRepository movieRepository = new MovieRepository();

                using (movieRepository)
                {
                    movieRepository.Insert(movie);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }



        // GET: Movie/Edit/5

        [HttpGet]
        public ActionResult Edit(int id)
        {
            MovieRepository movieRepository = new MovieRepository();
            Movie movie = new Movie();

            using (movieRepository)
            {
                movie = movieRepository.SelectOne(id);
            }

            return View(movie);
        }

        // POST: Movie/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            try
            {
                MovieRepository movieRepository = new MovieRepository();

                using (movieRepository)
                {
                    movieRepository.Update(movie);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }
        // GET: Movie/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            MovieRepository movieRepository = new MovieRepository();
            Movie movie = new Movie();

            using (movieRepository)
            {
                movie = movieRepository.SelectOne(id);
            }

            return View(movie);
        }


        [HttpPost]
        public ActionResult Delete(int id, Movie movie)
        {
            try
            {
                MovieRepository movieRepository = new MovieRepository();

                using (movieRepository)
                {
                    movieRepository.Delete(id);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                // TODO Add view for error message
                return View();
            }
        }
    }
}
