using PokemonTCG.Core.Models;
using PokemonTCG.Core.Enums;

namespace PokemonTCG.Core.Logic
{
    public static class CardData
    {
        public static PokemonCard GetBulbasaur() => new()
        {
            Name = "Bulbasaur",
            HP = 70,
            Type = EnergyType.Grass,
            Weakness = EnergyType.Fire,
            ImageUrl = "https://images.pokemontcg.io/sv3pt5/1_hires.png",
            Attacks = new()
            {
                new Attack
                {
                    Name = "Leech Seed",
                    Damage = 20,
                    CostType = EnergyType.Grass,
                    CostAmount = 2
                }
            }
        };

        public static PokemonCard GetCharmander() => new()
        {
            Name = "Charmander",
            HP = 70,
            Type = EnergyType.Fire,
            Weakness = EnergyType.Water,
            ImageUrl = "https://images.pokemontcg.io/sv3pt5/4_hires.png",
            Attacks = new()
            {
                new Attack
                {
                    Name = "Steady Firebreathing",
                    Damage = 30,
                    CostType = EnergyType.Fire,
                    CostAmount = 2
                }
            }
        };

        public static PokemonCard GetSquirtle() => new()
        {
            Name = "Squirtle",
            HP = 60,
            Type = EnergyType.Water,
            Weakness = EnergyType.Grass,
            ImageUrl = "https://images.pokemontcg.io/sv3pt5/7_hires.png",
            Attacks = new()
            {
                new Attack
                {
                    Name = "Skull Bash",
                    Damage = 20,
                    CostType = EnergyType.Water,
                    CostAmount = 2
                }
            }
        };
    }
}