using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IOrderItemService
{
    Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId);
}