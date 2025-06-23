using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface IUserRepository
{
    Task<User?> GetById(int id);
    Task<IEnumerable<User>> ListAll();
}