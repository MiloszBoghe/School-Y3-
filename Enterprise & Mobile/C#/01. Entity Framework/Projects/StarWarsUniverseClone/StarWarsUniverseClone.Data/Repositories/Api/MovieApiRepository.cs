using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using StarWarsUniverseClone.Domain;

namespace StarWarsUniverseClone.Data.Repositories.Api
{
    public class MovieApiRepository : IMovieRepository
    {
        private readonly HttpClient _httpClient;

        public MovieApiRepository()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://swapi.dev")
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IList<Movie> GetAllMovies()
        {
            const string url = "/api/films/";
            var allMovies = new List<Movie>();
            ResultsPage<Movie> resultsPage = null;
            var response = _httpClient.GetAsync(url).Result;
            if (!response.IsSuccessStatusCode) return allMovies;
            var content = response.Content.ReadAsStringAsync().Result; resultsPage = JsonConvert.DeserializeObject<ResultsPage<Movie>>(content); allMovies = resultsPage.Results;

            return allMovies;
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
