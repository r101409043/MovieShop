using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class OrderRepository(MovieShopDbContext dbContext) : IOrderRepository
{
    public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
    {
        return await dbContext.Orders
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.Movie)
            .Where(o => o.UserId == userId)
            .ToListAsync();
    }

    public async Task<Order> GetOrderByIdAsync(int orderId)
    {
        return (await dbContext.Orders
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.Movie)
            .FirstOrDefaultAsync(o => o.Id == orderId))!;
    }

    public async Task<Order> AddOrderAsync(Order order)
    {
        dbContext.Orders.Add(order);
        await dbContext.SaveChangesAsync();
        return order;
    }

    public async Task DeleteOrderAsync(int orderId)
    {
        var order = await dbContext.Orders
            .Include(o => o.OrderItems)
            .FirstOrDefaultAsync(o => o.Id == orderId);

        if (order != null)
        {
            dbContext.OrderItems.RemoveRange(order.OrderItems);
            dbContext.Orders.Remove(order);
            await dbContext.SaveChangesAsync();
        }
    }

    public async Task UpdateOrderAsync(int orderId, Order updatedOrder)
    {
        var existingOrder = await dbContext.Orders
            .Include(o => o.OrderItems)
            .FirstOrDefaultAsync(o => o.Id == orderId);

        if (existingOrder != null)
        {
            existingOrder.OrderDateTime = updatedOrder.OrderDateTime;
            existingOrder.TotalPrice = updatedOrder.TotalPrice;
            await dbContext.SaveChangesAsync();
        }
    }
}