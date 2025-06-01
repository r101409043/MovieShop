using ApplicationCore.Entities;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CastRepository : ICastRepository
{
    private readonly MovieShopDbContext _dbContext;

    public CastRepository(MovieShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Cast?> GetById(int id)
    {
        return await _dbContext.Casts
            .Include(c => c.MovieCasts)
            .ThenInclude(mc => mc.Movie)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}