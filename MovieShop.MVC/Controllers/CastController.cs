using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers
{
    public class CastController(ICastService castService) : Controller
    {
        public async Task<IActionResult> Details(int id)
        {
            var cast = await castService.GetCastDetails(id);
            return View(cast);
        }
    }
}