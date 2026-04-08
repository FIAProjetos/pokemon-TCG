using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonTCG.Core.Models
{
    public class Card
    {
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public string ImageUrl {get; set;} = string.Empty;
    }
}