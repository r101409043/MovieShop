using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Genre
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public ICollection<MovieGenre> MovieGenres { get; set; }
}