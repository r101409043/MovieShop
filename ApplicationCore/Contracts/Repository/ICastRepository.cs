using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface ICastRepository
{
    Task<Cast?> GetById(int id);
    Task<IEnumerable<Cast>> ListAll();
}