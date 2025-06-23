namespace ApplicationCore.Entities;

public class Cast
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<MovieCast> MovieCasts { get; set; }
}