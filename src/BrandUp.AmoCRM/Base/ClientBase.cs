using BrandUp.AmoCRM.Models;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;
using System.Text;

namespace BrandUp.AmoCRM
{
    internal class ClientBase : IClientBase
    {
        readonly static IDictionary<Type, string> pathDictionary = new Dictionary<Type, string>()
        {
            {typeof(Contact), "/api/v4/contacts" }
        };

        readonly HttpClient client;
        ILogger<ClientBase> logger;

        public ClientBase(HttpClient client, ILogger<ClientBase> logger)
        {
            this.client = client ?? throw new ArgumentNullException(nameof(client));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #region IAmoCRMClient members

        public async Task<IEnumerable<T>> GetAllAsync<T>(params string[] parameters)
        {
            var path = PathFor<T>(parameters);
            using var request = new HttpRequestMessage(HttpMethod.Get, path);

            using var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            var data = await response.Content.ReadFromJsonAsync<T[]>();
            return data;
        }

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

        private Uri PathFor<T>(string[] parameters)
        {
            var path = new StringBuilder(pathDictionary[typeof(T)]);
            path.Append("?");
            path.Append(string.Join("&", parameters));

            return new Uri(path.ToString());
        }

        #endregion
    }
}
