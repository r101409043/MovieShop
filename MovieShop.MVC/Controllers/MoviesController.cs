using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class MoviesController(IMovieService movieService) : Controller
    {
        public async Task<IActionResult> Details(int id)
        {
            var movie = await movieService.GetMovieDetails(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        public async Task<IActionResult> MoviesByGenre(int id, int pageSize = 30, int pageNumber = 1)
        {
            var pagedResult = await movieService.GetMoviesByGenrePaginated(id, pageNumber, pageSize);
            return View(pagedResult);
        }
    }
}