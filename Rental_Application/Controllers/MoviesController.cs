using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;
using System.Data.Entity;
using Rental_Application.ViewModels;
using System.Data.Entity.Validation;

namespace Rental_Application.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _Context;

        public MoviesController()
        {
            _Context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _Context.Dispose();
        }


        // GET: Movies
        public ViewResult Index()
        {
            var movies = _Context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _Context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.id == id);
            if (movies == null)
            {
                return HttpNotFound();
            }
            return View(movies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie Movie)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewMovieViewModel
                {
                    Movie = Movie,
                    Genres = _Context.Genres.ToList()
                };
                return View("NewMovie", viewmodel);
            }
            if (Movie.id == 0)
            {
                Movie.DateAdded = DateTime.Now;
                _Context.Movies.Add(Movie);
            }
            else
            {
                var MovieInDb = _Context.Movies.Single(m => m.id == Movie.id);
                MovieInDb.MovieName = Movie.MovieName;
                MovieInDb.GenreId = Movie.GenreId;
                MovieInDb.NumberInStock = Movie.NumberInStock;
                MovieInDb.ReleaseDate = Movie.ReleaseDate; ;
            }

            _Context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var Movie = _Context.Movies.SingleOrDefault(m => m.id == id);
            if (Movie == null)
                return HttpNotFound();
            var viewmodel = new NewMovieViewModel()
            {
                Movie = Movie,
                Genres = _Context.Genres.ToList()
            };

            return View("NewMovie", viewmodel);
        }
        public ViewResult NewMovie()
        {
            var Genres = _Context.Genres.ToList();
            var viewmodel = new NewMovieViewModel
            {
                Genres = Genres
            };
            return View("NewMovie", viewmodel);
        }



        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {id=1,MovieName="Fast & Furious 8" },
        //        new Movie {id=2,MovieName="Need For Speed" }
        //    };
        //}
    }
}