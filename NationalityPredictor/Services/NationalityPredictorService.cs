using NationalityPredictor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace NationalityPredictor.Services
{
    public class NationalityPredictorService : INationalityPredictorService
    {
        private readonly HttpClient client;

        public NationalityPredictorService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("NationalityPredictorService");
        }

        public async Task<DataModel> GetCountries(string name)
        {


            var url = string.Format("https://api.nationalize.io/?name={0}", name);

            var response = await client.GetAsync(url);
            var model = new DataModel();

            if (response.IsSuccessStatusCode)
            {
                
                var stringResponse = await response.Content.ReadAsStringAsync();

                model = JsonSerializer.Deserialize<DataModel>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return model;
        }
    }
}
