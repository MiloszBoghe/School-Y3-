using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data.Repositories.Api
{
    public class PlanetApiRepository : IPlanetRepository
    {
        private readonly HttpClient _httpClient;

        public PlanetApiRepository()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://swapi.dev")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IList<Planet> GetAllPlanets()
        {
            var url = "/api/planets/";
            var allPlanets = new List<Planet>();

            ResultsPage<Planet> resultsPage = null;
            var response = _httpClient.GetAsync(url).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            content = content.Replace("unknown", "-1");
            resultsPage = JsonConvert.DeserializeObject<ResultsPage<Planet>>(content);
            url = resultsPage.Next;
            allPlanets = resultsPage.Results;

            while (resultsPage.Next != null)
            {
                response = _httpClient.GetAsync(url).Result;
                content = response.Content.ReadAsStringAsync().Result;
                content = content.Replace("unknown", "-1");
                resultsPage = JsonConvert.DeserializeObject<ResultsPage<Planet>>(content);
                url = resultsPage.Next;
                allPlanets.AddRange(resultsPage.Results);
            }

            return allPlanets;
        }


        internal class ResultsPage<T>
        {
            public int Count { get; set; }
            public string Next { get; set; }
            public string Previous { get; set; }
            public List<T> Results { get; set; }
        }
    }
}
