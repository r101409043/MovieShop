using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

public class OrderController : Controller
{
    private readonly IOrderService _orderService;
    private readonly IMovieService _movieService;

    public OrderController(IOrderService orderService, IMovieService movieService)
    {
        _orderService = orderService;
        _movieService = movieService;
    }

    public async Task<IActionResult> Index()
    {
        var orders = await _orderService.GetOrdersByUserIdAsync(1);
        return View(orders);
    }

    [HttpPost]
    public async Task<IActionResult> Create(int movieId)
    {
        var movie = await _movieService.GetMovieDetails(movieId);
        if (movie == null)
        {
            return NotFound();
        }

        var order = new Order
        {
            UserId = 1,
            OrderDateTime = DateTime.UtcNow,
            TotalPrice = movie.Price,
            OrderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    MovieId = movie.Id,
                    Quantity = 1,
                    UnitPrice = movie.Price
                }
            }
        };

        await _orderService.CreateOrderAsync(order);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        await _orderService.DeleteOrderAsync(id);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);
        return View(order);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, Order updatedOrder)
    {
        await _orderService.UpdateOrderAsync(id, updatedOrder);
        return RedirectToAction("Index");
    }
}