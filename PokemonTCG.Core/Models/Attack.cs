using PokemonTCG.Core.Enums;

namespace PokemonTCG.Core.Models
{
    public class Attack
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public EnergyType CostType { get; set; }
        public int CostAmount { get; set; }
    }
}