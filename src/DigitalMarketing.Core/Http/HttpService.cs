using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMarketing.Core.Http
{
    public class HttpService : IHttpService
    {
        HttpClient _client;

        public HttpService(IHttpClientFactory httpClient)
        {
            _client = new HttpClient(new HttpClientHandler());
        }

        public async Task<string> GetAsync(string requestUri)
        {
            var result = await _client.GetAsync(requestUri);
            return await result.Content.ReadAsStringAsync();
        }

        public async Task<string> PostAsync(string requestUri, string jsonContent)
        {
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var result = await _client.PostAsync(requestUri, content);
            return await result.Content.ReadAsStringAsync();
        }

        public async Task<string> PutAsync(string requestUri, string jsonContent)
        {
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var result = await _client.PutAsync(requestUri, content);
            return await result.Content.ReadAsStringAsync();
        }
    }
}
