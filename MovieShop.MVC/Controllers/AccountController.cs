using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}