using Microsoft.AspNetCore.Mvc;
using Mission06_Griffin.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Griffin.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;
        public HomeController(JoelHiltonMovieCollectionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

            return View("Add", new Movie());
        }

        [HttpPost]
        public IActionResult Add(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add a record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName).ToList();

                return View(response);
            }
        }

        public IActionResult MovieList()
        {
            // First Linq query
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var record = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName).ToList();

            return View("Add", record);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
            .OrderBy(x => x.CategoryName).ToList();

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
