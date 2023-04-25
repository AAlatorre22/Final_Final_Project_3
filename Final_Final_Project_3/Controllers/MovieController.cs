using Final_Final_Project_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Final_Project_3.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            var movie = new Movie();
            return View(movie);
        }
    }
}
