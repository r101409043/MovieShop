namespace ApplicationCore.Entities;

public class OrderItem
{
    public int Id { get; init; }
    public int OrderId { get; init; }
    public int MovieId { get; init; }
    public int Quantity { get; init; }
    public decimal UnitPrice { get; init; }

    public Order? Order { get; set; }
    public Movie? Movie { get; set; }
}