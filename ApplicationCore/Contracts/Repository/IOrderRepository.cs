using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface IOrderRepository
{
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    Task<Order> GetOrderByIdAsync(int orderId);
    Task<Order> AddOrderAsync(Order order);
    Task DeleteOrderAsync(int orderId);
    Task UpdateOrderAsync(int orderId, Order updatedOrder);
}