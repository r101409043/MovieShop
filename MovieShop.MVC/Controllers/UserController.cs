using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Models;
using MovieShop.MVC.Models;
using MovieShop.MVC.Validators;

namespace MovieShop.MVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Purchase(int movieId)
        {
            var model = new PurchaseRequestModel
            {
                MovieId = movieId,
                PurchaseDateTime = DateTime.Today,
                TotalPrice = 10.00m,
                UserId = 1
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Purchase(PurchaseRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}