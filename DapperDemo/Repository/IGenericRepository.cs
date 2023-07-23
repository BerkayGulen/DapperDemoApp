namespace DapperDemo.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task Delete(int id);
        Task<T?> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Insert(T entity);
        Task Update(T entity);

    }
}
