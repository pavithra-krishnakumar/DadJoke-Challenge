using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DadJoke.Data
{
    public class SearchJokeApiResponse
    {

        [JsonPropertyName("results")]
        public List<RandomJokeApiResponse>  JokeApiResponses { get; set; }

        [JsonPropertyName("current_page")]
        public int CurrentPage { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPage { get; set; }
    }
}
