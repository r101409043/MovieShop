using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services;

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
    
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<Movie?> GetMovieDetails(int id)
    {
        return await _movieRepository.GetMovieById(id);
    }
}