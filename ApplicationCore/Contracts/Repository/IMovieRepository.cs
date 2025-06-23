using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Repository;

public interface IMovieRepository
{
    Task<List<Movie>> GetHighestGrossingMovies(int count = 30);
    Task<Movie?> GetMovieById(int id);
    Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId, int pageNumber, int pageSize);
    Task<PaginatedResultSet<Movie>> GetMoviesByGenrePaginated(int genreId, int pageNumber, int pageSize);
}