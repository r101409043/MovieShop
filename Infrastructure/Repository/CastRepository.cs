using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CastRepository(MovieShopDbContext dbContext) : ICastRepository
{
    public async Task<Cast?> GetById(int id)
    {
        return await dbContext.Casts
            .Include(c => c.MovieCasts)
            .ThenInclude(mc => mc.Movie)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Cast>> ListAll()
    {
        return await dbContext.Casts.ToListAsync();
    }
}