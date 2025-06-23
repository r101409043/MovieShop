using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class AccountService : IAccountService
{
    public async Task<User?> GetUserByEmail(string email)
    {
        var dummy = new User
        {
            Id = 1,
            FirstName = "Test",
            Email = email
        };
        return await Task.FromResult(dummy);
    }
}