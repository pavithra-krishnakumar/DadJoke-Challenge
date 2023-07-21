using System.Threading.Tasks;
using DadJoke.Models;

namespace DadJoke.Interfaces
{
    public interface IDadJokeService
    { 
        Task<DadJokeModel> GetRandomJokeAsync();

        Task<DadJokeModel> GetJokesBySearchTerm(string term);
    }
}
