using PokemonTCG.Core.Enums;

namespace PokemonTCG.Core.Models
{
    public class PokemonCard : Card
    {
        public int HP { get; set; }
        public EnergyType Type { get; set; }
        public EnergyType Weakness { get; set; }
        public List<Attack> Attacks { get; set; } = new();
        public List<EnergyType> AttachedEnergies { get; set; } = new();
    }
}