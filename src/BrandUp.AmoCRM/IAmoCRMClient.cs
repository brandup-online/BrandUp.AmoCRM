namespace BrandUp.AmoCRM
{
    public interface IAmoCRMClient
    {
        Task<IEnumerable<T>> GetAllAsync<T>();
        Task<T> GetAsync<T>();
        Task PostAsync<T>(T entity);
        Task PostAsync<T>(T[] entity);
        Task PathcAsync<T>(T[] entity);
        Task PathcAsync<T>(int id, T entity);
    }
}