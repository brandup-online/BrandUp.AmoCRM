using Microsoft.Extensions.Logging;

namespace BrandUp.AmoCRM
{
    internal class ClientBase : IClientBase
    {
        readonly HttpClient client;
        ILogger<ClientBase> logger;

        public ClientBase(HttpClient client, ILogger<ClientBase> logger)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #region IClientBase members

        public Task<T> GetAsync<T>(params string[] parameters)
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

        public Task PostAsync<T>(T[] entity)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Helpers

        //private Uri PathFor<T>(string[] parameters)
        //{
        //    var path = new StringBuilder(pathDictionary[typeof(T)]);
        //    path.Append("?");
        //    path.Append(string.Join("&", parameters));

        //    return new Uri(path.ToString());
        //}

        #endregion
    }
}
