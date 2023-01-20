using Microsoft.Extensions.Logging;

namespace BrandUp.AmoCRM
{
    public class AmoCRMClient : IAmoCRMClient
    {
        readonly HttpClient client;
        ILogger<AmoCRMClient> logger;

        public AmoCRMClient(HttpClient client, ILogger<AmoCRMClient> logger)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #region IAmoCRMClient members

        public Task<IEnumerable<T>> GetAllAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync<T>()
        {
            throw new NotImplementedException();
        }

        public Task PathcAsync<T>(T[] entity)
        {
            throw new NotImplementedException();
        }

        public Task PathcAsync<T>(int id, T entity)
        {
            throw new NotImplementedException();
        }

        public Task PostAsync<T>(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
