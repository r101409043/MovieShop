using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required] [MaxLength(256)]
        public string Title { get; set; }

        public string Overview { get; set; }

        public decimal Price { get; set; }

        [MaxLength(512)]
        public string? PosterUrl { get; set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieCast> MovieCasts { get; set; }
        public ICollection<Trailer> Trailers { get; set; }
    }
}