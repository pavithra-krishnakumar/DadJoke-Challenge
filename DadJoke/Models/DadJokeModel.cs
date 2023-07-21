using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DadJoke.Models
{
    public class DadJokeModel
    {
        /// <summary>
        /// Random joke
        /// </summary>
        public string Joke { get; set; }

        /// <summary>
        /// Term for searching a list of jokes
        /// </summary>
        [Display(Name = "Do you want to laugh more, search joke here!")]
        [Required(AllowEmptyStrings = false)]
        public string Term { get; set; }

        /// <summary>
        /// Short joke list
        /// </summary>
        public List<string> ShortJokeList { get; set; }

        /// <summary>
        /// Medium joke list
        /// </summary>
        public List<string> MediumJokeList { get; set; }

        /// <summary>
        /// Long joke list
        /// </summary>
        public List<string> LongJokeList { get; set; }

    }
}
