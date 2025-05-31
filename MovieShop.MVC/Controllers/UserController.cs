using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}