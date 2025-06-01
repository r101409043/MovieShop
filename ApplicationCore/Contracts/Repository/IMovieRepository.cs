using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface IMovieRepository
{
    Task<List<Movie>> GetHighestGrossingMovies(int count = 30);
    Task<Movie?> GetMovieById(int id);
}