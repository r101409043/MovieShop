using ApplicationCore.Contracts.Repository;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Entities;

namespace Infrastructure.Services;

public class CastService(ICastRepository castRepository) : ICastService
{
    public async Task<Cast?> GetCastDetails(int id)
    {
        return await castRepository.GetById(id);
    }

    public async Task<IEnumerable<Cast>> GetAllCasts()
    {
        return await castRepository.ListAll();
    }
}