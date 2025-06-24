using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface IOrderItemRepository
{
    Task<IEnumerable<OrderItem>> GetOrderItemsByOrderIdAsync(int orderId);
}