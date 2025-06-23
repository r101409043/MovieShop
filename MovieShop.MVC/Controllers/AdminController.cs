using Microsoft.AspNetCore.Mvc;
using MovieShop.MVC.Filters;

namespace MovieShop.MVC.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    [LogRequest]
    public IActionResult CreateMovie()
    {
        return View();
    }
}