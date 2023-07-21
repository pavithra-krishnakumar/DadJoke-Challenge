using System.Text.Json.Serialization;

namespace DadJoke.Data
{
    public class RandomJokeApiResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("joke")]
        public string Joke { get; set; }
    }
}
