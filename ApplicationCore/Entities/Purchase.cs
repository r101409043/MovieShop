namespace ApplicationCore.Entities;

public class Purchase
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int MovieId { get; set; }

    public decimal TotalPrice { get; set; }
    public DateTime PurchaseDateTime { get; set; }

    public User User { get; set; }
    public Movie Movie { get; set; }
}
