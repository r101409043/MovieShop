using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface IAccountService
{
    Task<User?> GetUserByEmail(string email);
}