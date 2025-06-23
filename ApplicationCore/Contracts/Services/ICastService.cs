using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Services;

public interface ICastService
{
    Task<Cast?> GetCastDetails(int id);
    Task<IEnumerable<Cast>> GetAllCasts();
}