using System;
using DadJoke.Interfaces;
using DadJoke.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DadJoke.Data;
using Microsoft.Extensions.Configuration;
using NLog;

namespace DadJoke.Services
{
    public class DadJokeService : IDadJokeService
    {
        private readonly ILogger _logger = LogManager.GetCurrentClassLogger();
        private readonly IConfiguration _configuration;

        public DadJokeService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Fetch a random joke
        /// </summary>
        /// <returns>Dad joke model</returns>
        public async Task<DadJokeModel> GetRandomJokeAsync()
        {
            _logger.Info("Random Joke Service invoked");
            var apiResult = new RandomJokeApiResponse();
            try
            {
                var apiManager = GetDadJokeApiManager();
                apiResult = await apiManager.ReadARandomJoke();
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            return new DadJokeModel
            {
                Joke = apiResult.Joke
            };
        }

        /// <summary>
        /// Search for jokes based on the search term
        /// </summary>
        /// <param name="term">search term</param>
        /// <returns>Dad joke model</returns>
        public async Task<DadJokeModel> GetJokesBySearchTerm(string term)
        {
            _logger.Info("Joke by search term service invoked");
            DadJokeModel model = new DadJokeModel();
            try
            {
                var apiManager = GetDadJokeApiManager();
                var apiResult = await apiManager.ReadJokesByTerm(term);
                foreach (var i in apiResult)
                {
                    i.Joke = FormatJoke(i.Joke, term);
                    GroupJoke(i.Joke, model);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
            return model;
        }

        /// <summary>
        /// Format the joke to highlight the search term in uppercase
        /// </summary>
        /// <param name="joke">Joke sentence</param>
        /// <param name="term">term to highlight</param>
        /// <returns>Formatted joke</returns>
        private static string FormatJoke(string joke, string term)
        {
            var words = term?.Split(' ');
            return words?.Aggregate(joke, (current, word) => current.Replace(word, word.ToUpper(), StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Group joke based on the numbr of words in the joke. < 10 : Short, < 20 Medium, >=20 Long
        /// </summary>
        /// <param name="joke">joke</param>
        /// <param name="model">Dad joke model</param>
        private void GroupJoke(string joke, DadJokeModel model)
        {
            var wordsCount = joke.Split(' ').Length;
            var size = wordsCount < 10 ? "small" : wordsCount < 20 ? "medium" : "long";
            switch (size){
                case "small":
                    {
                        if(model.ShortJokeList != null)
                        {
                            model.ShortJokeList.Add(joke);
                        }
                        else
                        {
                            model.ShortJokeList = new List<string>
                            {
                                joke
                            };
                        }
                        break;
                    }
                case "medium":
                    {
                        if (model.MediumJokeList != null)
                        {
                            model.MediumJokeList.Add(joke);
                        }
                        else
                        {
                            model.MediumJokeList = new List<string>
                            {
                                joke
                            };
                        }
                        break;
                    }
                default:
                    {
                        if (model.LongJokeList != null)
                        {
                            model.LongJokeList.Add(joke);
                        }
                        else
                        {
                            model.LongJokeList = new List<string>
                            {
                                joke
                            };
                        }
                        break;
                    }
            }       
        }

        /// <summary>
        /// Create the object of the API caller
        /// </summary>
        /// <returns>API caller object</returns>
        private DadJokeApiCaller GetDadJokeApiManager()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return new DadJokeApiCaller(client, _configuration);
        }
    }
}
