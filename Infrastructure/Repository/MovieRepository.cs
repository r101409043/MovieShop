using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class MovieRepository : IMovieRepository
{
    private readonly MovieShopDbContext _dbContext;

    public MovieRepository(MovieShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Movie>> GetHighestGrossingMovies(int count = 30)
    {
        return await _dbContext.Movies
            .OrderByDescending(m => m.Price) 
            .Take(count)
            .ToListAsync();
    }
    
    public async Task<Movie?> GetMovieById(int id)
    {
        return await _dbContext.Movies
            .Include(m => m.MovieGenres).ThenInclude(mg => mg.Genre)
            .Include(m => m.MovieCasts).ThenInclude(mc => mc.Cast)
            .Include(m => m.Trailers)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}