using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository
{
    public interface IReportRepository
    {
        Task<IEnumerable<Purchase>> GetAllPurchasesForUser(int userId);
        Task<decimal> GetTotalRevenue();
    }
}