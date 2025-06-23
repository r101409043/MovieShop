using ApplicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.ViewComponents;

public class GenresViewComponent(IGenreService genreService) : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var genres = await genreService.GetAllGenres();
        return View(genres);
    }
}