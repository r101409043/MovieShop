using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public class MovieService : IMovieService
{
    public async Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies()
    {
        var movies = new List<MovieCardModel>
        {
            new() { Id = 1, Title = "Inception", PosterUrl = "https://image.tmdb.org/t/p/w500/inception.jpg" },
            new() { Id = 2, Title = "Endgame", PosterUrl = "https://image.tmdb.org/t/p/w500/endgame.jpg" },
            new() { Id = 3, Title = "Dark Knight", PosterUrl = "https://image.tmdb.org/t/p/w500/darkknight.jpg" }
        };

        return await Task.FromResult(movies);
    }
}