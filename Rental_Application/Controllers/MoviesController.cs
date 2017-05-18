using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;
using System.Data.Entity;
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
            return View(movies);
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