using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class OrderItemService(IOrderItemRepository orderItemRepository) : IOrderItemService
{
    public async Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId)
    {
        return await orderItemRepository.GetOrderItemsByOrderIdAsync(orderId);
    }
}