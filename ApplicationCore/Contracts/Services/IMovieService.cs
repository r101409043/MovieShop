using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies();
    Task<Movie?> GetMovieDetails(int id);
    Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId, int pageNumber, int pageSize);
    Task<PaginatedResultSet<Movie>> GetMoviesByGenrePaginated(int genreId, int pageNumber, int pageSize);
}