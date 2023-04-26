using Final_Final_Project_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Final_Final_Project_3.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repo;
        public MovieController(IMovieRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var movie = new Movie();

            movie = _repo.GetApiResponse();

            return View(movie);
        }
    }
}
