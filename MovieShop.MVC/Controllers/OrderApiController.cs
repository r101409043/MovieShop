using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MovieShop.MVC.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderApiController(IOrderService orderService) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var orders = await orderService.GetOrdersByUserIdAsync(1);
        return Ok(orders);
    }

    [HttpGet("user/{userId:int}")]
    public async Task<IActionResult> GetOrdersByUser(int userId)
    {
        var orders = await orderService.GetOrdersByUserIdAsync(userId);
        return Ok(orders);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] Order order)
    {
        if (order.OrderItems.Count == 0)
        {
            return BadRequest("Invalid order data.");
        }

        var created = await orderService.CreateOrderAsync(order);
        return CreatedAtAction(nameof(GetOrdersByUser), new { userId = order.UserId }, created);
    }
    
    [HttpDelete("{orderId:int}")]
    public async Task<IActionResult> DeleteOrder(int orderId)
    {
        await orderService.DeleteOrderAsync(orderId);
        return NoContent();
    }
    
    [HttpPut("{orderId:int}")]
    public async Task<IActionResult> UpdateOrder(int orderId, [FromBody] Order order)
    {
        if (order.OrderItems.Count == 0)
        {
            return BadRequest("Invalid order data.");
        }

        await orderService.UpdateOrderAsync(orderId, order);
        return NoContent();
    }
}