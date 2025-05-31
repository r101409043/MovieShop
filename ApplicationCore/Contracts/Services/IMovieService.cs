using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies();
}