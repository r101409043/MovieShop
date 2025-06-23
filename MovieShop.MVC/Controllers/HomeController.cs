using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class HomeController(IMovieService movieService) : Controller
{
    public async Task<IActionResult> Index()
    {
        var movies = await movieService.GetTopRevenueMovies();
        return View(movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}