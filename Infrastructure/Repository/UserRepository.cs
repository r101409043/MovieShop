using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class UserRepository(MovieShopDbContext dbContext) : IUserRepository
{
    public async Task<User?> GetById(int id)
    {
        return await dbContext.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> ListAll()
    {
        return await dbContext.Users.ToListAsync();
    }
}