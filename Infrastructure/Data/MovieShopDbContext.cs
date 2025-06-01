using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;

namespace Infrastructure.Data
{
    public class MovieShopDbContext : DbContext
    {
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Trailer> Trailers { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieId, mg.GenreId });

            modelBuilder.Entity<MovieCast>()
                .HasKey(mc => new { mc.MovieId, mc.CastId });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Fantasy" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Overview = "Dream inside dream", Price = 12.99M },
                new Movie { Id = 2, Title = "Avengers", Overview = "Superhero team", Price = 14.99M }
            );

            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { MovieId = 1, GenreId = 4 },
                new MovieGenre { MovieId = 2, GenreId = 1 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Tony", Email = "tony@stark.com" },
                new User { Id = 2, FirstName = "Steve", Email = "steve@rogers.com" }
            );

            modelBuilder.Entity<Cast>().HasData(
                new Cast { Id = 1, Name = "Leonardo DiCaprio" },
                new Cast { Id = 2, Name = "Robert Downey Jr." }
            );

            modelBuilder.Entity<MovieCast>().HasData(
                new MovieCast { MovieId = 1, CastId = 1 },
                new MovieCast { MovieId = 2, CastId = 2 }
            );
        }
    }
}