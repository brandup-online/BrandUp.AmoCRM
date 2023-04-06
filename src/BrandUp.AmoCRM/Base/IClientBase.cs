namespace BrandUp.AmoCRM
{
    public interface IClientBase
    {
        Task<T> GetAsync<T>(params string[] parameters);
        Task PostAsync<T>(T entity);
        Task PostAsync<T>(T[] entity);
        Task PathcAsync<T>(T[] entity);
        Task PathcAsync<T>(int id, T entity);
    }
}