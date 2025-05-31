using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class CastController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}