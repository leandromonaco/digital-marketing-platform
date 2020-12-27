﻿using System.Threading.Tasks;

namespace DigitalMarketing.Core.Http
{
    public interface IHttpService
    {
        Task<string> GetAsync(string requestUri);
        Task<string> PostAsync(string requestUri, string jsonContent);
        Task<string> PutAsync(string requestUri, string jsonContent);
    }
}