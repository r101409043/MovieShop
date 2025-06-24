using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class OrderItemRepository(MovieShopDbContext dbContext) : IOrderItemRepository
{
    public async Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId)
    {
        return await dbContext.OrderItems
            .Where(oi => oi.OrderId == orderId)
            .Include(oi => oi.Movie)
            .ToListAsync();
    }
}