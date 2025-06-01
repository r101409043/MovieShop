using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}