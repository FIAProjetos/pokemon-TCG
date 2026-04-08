using PokemonTCG.Core.Models;
using PokemonTCG.Core.Enums;

namespace PokemonTCG.Core.Logic
{
    public static class BattleEngine
    {
        // Calculates the damage of an attack considering weaknesses
        public static int CalculateDamage(PokemonCard attacker, PokemonCard defender, Attack attack)
        {
            int totalDamage = attack.Damage;

            // Check for weakness
            if (attack.CostType == defender.Weakness)
            {
                totalDamage *= 2; // Double damage for weakness
            }
            
            return totalDamage;
        }

        // Verifies if the attacker has enough energy to perform the attack
        public static bool HasEnoughEnergy(PokemonCard pokemon, Attack attack)
        {
            int energyCount = pokemon.AttachedEnergies.Count(e => e == attack.CostType);
            return energyCount >= attack.CostAmount;
        }

        // Aplies the attack damage 
        public static string ExecuteAttack(PokemonCard attacker, PokemonCard defender, Attack attack)
        {
            if (!HasEnoughEnergy(attacker, attack))
            {
                return $"{attacker.Name} não tem energia suficiente para usar {attack.Name}.";
            }

            int damage = CalculateDamage(attacker, defender, attack);

            defender.HP -= damage;

            string message = $"{attacker.Name} usou {attack.Name} causando {damage} de dano!";

            if (defender.Weakness == attack.CostType)
            {
                message += " Foi super efetivo!";
            }
            if (defender.HP <= 0)
            {   
                defender.HP = 0; // Garantee HP doesn't go negative
                message += $" {defender.Name} foi nocauteado!";
            }
            return message;
        }

        public static string AttachEnergy(PokemonCard pokemon, EnergyCard energy)
        {
            pokemon.AttachedEnergies.Add(energy.Type);
            return $"{energy.Type} energia foi anexada a {pokemon.Name}. Total: {pokemon.AttachedEnergies.Count}";
        }

        public static bool CanRetreat(PokemonCard pokemon)
        {
            return pokemon.AttachedEnergies.Count >= pokemon.RetreatCost;
        }
    }
}