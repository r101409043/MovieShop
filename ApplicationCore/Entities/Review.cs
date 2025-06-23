namespace ApplicationCore.Entities;

public class Review
{
    public int UserId { get; set; }
    public int MovieId { get; set; }

    public decimal Rating { get; set; }
    public string ReviewText { get; set; }

    public User User { get; set; }
    public Movie Movie { get; set; }
}