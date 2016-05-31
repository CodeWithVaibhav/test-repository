using System.Collections.Generic;
using System.Web.Mvc;
using Yagani.Web.Models;

namespace Yagani.Web.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Iron Man!"},
                new Movie{Name = "Italian Job!"}
            };

            return View(movies);
        }
    }
}