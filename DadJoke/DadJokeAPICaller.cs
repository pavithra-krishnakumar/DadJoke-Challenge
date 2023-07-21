using System;
using System.Collections.Generic;
using DadJoke.Data;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using NLog;

namespace DadJoke
{
    public class DadJokeApiCaller
    {
        public const string RandomJokeUrl = "https://icanhazdadjoke.com/";
        public const string SearchJokeByTermUrl = "https://icanhazdadjoke.com/search?term={0}&limit={1}&page={2}";
        private readonly HttpClient _client;
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        private readonly IConfiguration _configuration;
       

        public DadJokeApiCaller(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _configuration = configuration;
        }

        /// <summary>
        /// Search for dad jokes by input term
        /// </summary>
        /// <param name="term">Search term</param>
        /// <param name="configuration">appsettings config</param>
        /// <returns>List of joke api response of give specific search term</returns>
        public async Task<List<RandomJokeApiResponse>> ReadJokesByTerm(string term)
        {
            var limit = _configuration.GetValue<string>("DadJokeAPISettings:Limit");
            var max = _configuration.GetValue<int>("DadJokeAPISettings:Max Jokes");
            int page = 1; int currentpage = 1; int totalpage = 1;
            var jokeList = new List<RandomJokeApiResponse>();
            try
            {
                while (currentpage <= totalpage && jokeList.Count < max)
                {
                    var url = string.Format(SearchJokeByTermUrl, term, limit, page);
                    var response = await _client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<SearchJokeApiResponse>(stringResponse);
                    currentpage = result.CurrentPage;
                    totalpage = result.TotalPage;
                    jokeList.AddRange(result.JokeApiResponses);
                    page++;
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.Error("Search dad joke API request failed.{0}", ex);
            }
            catch (Exception ex)
            {
               _logger.Error(ex);
            }
            
            return jokeList;
        }

        /// <summary>
        /// Fetch a random joke using api
        /// </summary>
        /// <returns>random joke</returns>
        public async Task<RandomJokeApiResponse> ReadARandomJoke()
        {
            RandomJokeApiResponse result = new RandomJokeApiResponse();
            try
            {
                var response = await _client.GetAsync(RandomJokeUrl);
                response.EnsureSuccessStatusCode();
                var stringResponse = await response.Content.ReadAsStringAsync();
                result = JsonSerializer.Deserialize<RandomJokeApiResponse>(stringResponse);
            }
            catch (HttpRequestException ex)
            {
                _logger.Error("Random dad joke API request failed.{0}", ex);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }

            return result;
        }
    }
}
