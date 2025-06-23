using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class MovieRepository(MovieShopDbContext dbContext) : IMovieRepository
{
    public async Task<List<Movie>> GetHighestGrossingMovies(int count = 30)
    {
        return await dbContext.Movies
            .OrderByDescending(m => m.Price) 
            .Take(count)
            .ToListAsync();
    }
    
    public async Task<Movie?> GetMovieById(int id)
    {
        return await dbContext.Movies
            .Include(m => m.MovieGenres).ThenInclude(mg => mg.Genre)
            .Include(m => m.MovieCasts).ThenInclude(mc => mc.Cast)
            .Include(m => m.Trailers)
            .FirstOrDefaultAsync(m => m.Id == id);
    }
    
    public async Task<IEnumerable<Movie>> GetMoviesByGenre(int genreId, int pageNumber, int pageSize)
    {
        return await dbContext.Movies
            .Where(m => m.MovieGenres.Any(mg => mg.GenreId == genreId))
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Include(m => m.MovieGenres)
            .ThenInclude(mg => mg.Genre)
            .ToListAsync();
    }
    
    public async Task<PaginatedResultSet<Movie>> GetMoviesByGenrePaginated(int genreId, int pageNumber, int pageSize)
    {
        var query = dbContext.Movies
            .Where(m => m.MovieGenres.Any(mg => mg.GenreId == genreId));

        var totalCount = await query.CountAsync();
        var items = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Include(m => m.MovieGenres).ThenInclude(mg => mg.Genre)
            .ToListAsync();

        return new PaginatedResultSet<Movie>
        {
            Items = items,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalCount = totalCount
        };
    }
}