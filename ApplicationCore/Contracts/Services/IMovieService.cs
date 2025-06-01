using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services;

public interface IMovieService
{
    Task<IEnumerable<MovieCardModel>> GetTopRevenueMovies();
    Task<Movie?> GetMovieDetails(int id);
}