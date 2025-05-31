using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Repository;

public interface IMovieRepository
{
    Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies();
}