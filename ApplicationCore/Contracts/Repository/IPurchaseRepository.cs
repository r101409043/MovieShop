using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository;

public interface IPurchaseRepository
{
    Task<IEnumerable<Purchase>> GetAllPurchases();
    Task<Purchase?> GetPurchaseById(int id);
}