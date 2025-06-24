namespace ApplicationCore.Entities;

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDateTime { get; set; }
    public decimal TotalPrice { get; set; }

    public User User { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}