using CrimeStatistics.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrimeStatistics.Persistance
{
    public class ApiRequestService
    {
        public async Task<HttpContent> ExecuteApiRequest(string appendage)
        {
            using (HttpResponseMessage response = await WebContext.WebApiClient.GetAsync(WebContext.WebApiClient.BaseAddress + appendage))
            {
                if (response.IsSuccessStatusCode)
                {
                    return response.Content;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
