using System.Collections.Generic;
using System.Web.Mvc;
using VidlyMy.Models;
using VidlyMy.ViewModels;
using System.Data.Entity;
using System;
using System.Linq;

namespace VidlyMy.Controllers
{
    public class MoviesController : Controller
    {


        private CustomerContext _context;

        public MoviesController()
        {
            _context = new CustomerContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }





        public ViewResult Index()
        {
            var Movies = _context.Movies.Include(m => m.Genre).ToListAsync();

            
            return View(Movies);
        }

        public ViewResult New()
        {
            var genres = _context.Movies.Include(m => m.Genre).ToListAsync();
            var viewModel = new MovieFormViewModel
            {
               // не підключає жанр
            };

            return View("MovieForm", viewModel);

        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.ReleaseDate = movie.ReleaseDate;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}
