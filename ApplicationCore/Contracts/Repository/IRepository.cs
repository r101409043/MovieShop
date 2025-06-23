namespace ApplicationCore.Contracts.Repository;

public interface IRepository<T> where T : class
{
    Task<T> GetById(int id);
    Task<IEnumerable<T>> ListAll();
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task Delete(T entity);
}