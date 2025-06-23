namespace ApplicationCore.Entities;

public class Crew
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<MovieCrew> MovieCrews { get; set; }
}
