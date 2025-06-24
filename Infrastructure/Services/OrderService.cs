using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class OrderService(IOrderRepository orderRepository) : IOrderService
{
    public async Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId)
    {
        return await orderRepository.GetOrdersByUserIdAsync(userId);
    }

    public async Task<Order> GetOrderByIdAsync(int orderId)
    {
        return await orderRepository.GetOrderByIdAsync(orderId);
    }

    public async Task<Order> CreateOrderAsync(Order order)
    {
        return await orderRepository.AddOrderAsync(order);
    }

    public async Task DeleteOrderAsync(int orderId)
    {
        await orderRepository.DeleteOrderAsync(orderId);
    }

    public async Task UpdateOrderAsync(int orderId, Order updatedOrder)
    {
        await orderRepository.UpdateOrderAsync(orderId, updatedOrder);
    }
}