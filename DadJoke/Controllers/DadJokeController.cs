using DadJoke.Interfaces;
using DadJoke.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DadJoke.Controllers
{
    public class DadJokeController : Controller
    {
        private readonly ILogger<DadJokeController> _logger;
        private readonly IDadJokeService _dadJokeService;

        public DadJokeController(ILogger<DadJokeController> logger, IDadJokeService dadJokeService)
        {
            _logger = logger;
            _dadJokeService = dadJokeService;
        }

        /// <summary>
        /// Default Index view of the controller
        /// </summary>
        /// <returns></returns>
        public IActionResult DadJokeIndex()
        {            
            return View();
        }

        /// <summary>
        /// Action method to fetch a random joke
        /// </summary>
        /// <returns>Index view with the dad joke model</returns>
        public async Task<IActionResult> GetRandomJoke()
        {
            _logger.LogInformation("GetRandomJoke action invoked.");
            DadJokeModel dadJoke = await _dadJokeService.GetRandomJokeAsync();
            return View("DadJokeIndex",dadJoke);
        }

        /// <summary>
        /// Action method to search dad jokes by term
        /// </summary>
        /// <param name="model">dad joke model</param>
        /// <returns>Index view with the dad joke model</returns>
        public async Task<IActionResult> GetJokesBySearchTerm(DadJokeModel model)
        {
            //check if model is in valid state. Search term is required feild, so will proceed only if we the term in the model object
            if (ModelState.IsValid)
            {
                _logger.LogInformation("GetJokesBySearchTerm action invoked.");
                DadJokeModel dadJoke = await _dadJokeService.GetJokesBySearchTerm(model.Term);
                return View("DadJokeIndex", dadJoke);
            }

            _logger.LogInformation("Dad Joke model is not valid. Make sure search term is entered.");
            return View("DadJokeIndex", model);
        }
    }
}
