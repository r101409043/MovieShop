using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services
{
    public interface IUserService
    {
        Task<User?> GetUserById(int id);
        Task<IEnumerable<User>> GetAllUsers();
    }
}