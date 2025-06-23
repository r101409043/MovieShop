using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace Infrastructure.Services;

public class MovieService(IMovieRepository movieRepository) : IMovieService
{
    public async Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies()
    {
        var movies = await movieRepository.GetHighestGrossingMovies();

        var result = movies.Select(m => new MovieCardModel
        {
            Id = m.Id,
            Title = m.Title,
            PosterUrl = m.PosterUrl
        });

        return result;
    }

    public async Task<Movie?> GetMovieDetails(int id)
    {
        return await movieRepository.GetMovieById(id);
    }

    public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId, int pageNumber, int pageSize)
    {
        return await movieRepository.GetMoviesByGenre(genreId, pageNumber, pageSize);
    }

    public async Task<PaginatedResultSet<Movie>> GetMoviesByGenrePaginated(int genreId, int pageNumber, int pageSize)
    {
        return await movieRepository.GetMoviesByGenrePaginated(genreId, pageNumber, pageSize);
    }
}