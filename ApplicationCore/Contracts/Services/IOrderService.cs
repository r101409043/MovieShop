using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    Task<Order> GetOrderByIdAsync(int orderId);
    Task<Order> CreateOrderAsync(Order order);
    Task DeleteOrderAsync(int orderId);
    Task UpdateOrderAsync(int orderId, Order updatedOrder);
}