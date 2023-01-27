namespace BrandUp.AmoCRM
{
    internal interface IAmoCRMBaseClient
    {
        Task<IEnumerable<T>> GetAllAsync<T>(params string[] parameters);
        Task<T> GetAsync<T>(params string[] parameters);
        Task PostAsync<T>(T entity);
        Task PostAsync<T>(T[] entity);
        Task PathcAsync<T>(T[] entity);
        Task PathcAsync<T>(int id, T entity);
    }
}