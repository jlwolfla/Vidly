using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        List<Movie> movies = new List<Movie>
        {
            new Movie {Id = 1, Name = "Die Hard"},
            new Movie {Id = 2, Name = "The Matrix"},
            new Movie {Id = 3, Name = "Walking Hard"},
            new Movie {Id = 4, Name = "Rambo"}
        };

        public ActionResult Index()
        {

            return View(movies);

        }


        public ActionResult Details(int? Id)
        {

            var movie = (from _c in movies where _c.Id == Id select _c).FirstOrDefault();
            return View(movie);
        }




        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Die Hard"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "John Wolfla"},
                new Customer {Name = "Patrice Wolfla"},
                new Customer {Name = "Joe Wolfla"},
                new Customer {Name = "Patrice Wolfla"},
                new Customer {Name = "Madison Wolfla"},
                new Customer {Name = "Nick Wolfla"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Customers = customers,
                Movie = movie
            };

            return View(ViewModel);
        }

        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        {
            return Content(year + "/" + month);
        }

    }
}