using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class Genre
{
    public int Id { get; init; }
    [Required]
    public string? Name { get; init; }

    public ICollection<MovieGenre>? MovieGenres { get; init; }
}