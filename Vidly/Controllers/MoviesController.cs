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

        private VidlyDb _context;


        public MoviesController()
        {
            _context = new VidlyDb();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }


        public ActionResult Index()
        {
            var movies = (from _c in _context.Movies select _c).ToList();
            return View(movies);

        }


        public ActionResult Details(int? Id)
        {

            //var movie = (from _c in movies where _c.Id == Id select _c).FirstOrDefault();

            //if (movie != null)
            //{
            //    return View(movie);
            //}
            //else
            //{
                return HttpNotFound();
            //}
            
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