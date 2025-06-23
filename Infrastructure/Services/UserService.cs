using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<User?> GetUserById(int id)
    {
        return await userRepository.GetById(id);
    }

    public async Task<IEnumerable<User>> GetAllUsers()
    {
        return await userRepository.ListAll();
    }
}