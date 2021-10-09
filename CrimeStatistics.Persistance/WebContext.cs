using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CrimeStatistics.Persistance
{
    public static class WebContext
    {
        public static HttpClient WebApiClient { get; set; } 

        public static void InitialiseClient()
        {
            WebApiClient = new HttpClient();
            WebApiClient.BaseAddress = new Uri("https://data.police.uk/api/");
            WebApiClient.DefaultRequestHeaders.Accept.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
