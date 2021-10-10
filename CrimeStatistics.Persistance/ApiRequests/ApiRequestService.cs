using CrimeStatistics.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrimeStatistics.Persistance
{
    public class ApiRequestService
    {
        public async Task<T> ExecuteApiRequest<T>(string url)
        {
            using (HttpResponseMessage response = await WebContext.WebApiClient.GetAsync(WebContext.WebApiClient.BaseAddress + url))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
