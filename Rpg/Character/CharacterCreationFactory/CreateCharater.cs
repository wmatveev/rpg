using System;
using RPG.Weapons.DamageCalculation;

namespace RPG.Character.CharacterCreationFactory
{
    public class CharactersFactory : ICharatersFactory
    {
        private readonly Balance           _balance;
        private readonly IDamageCalculator _damageCalculator;

        public CharactersFactory(Balance balance, IDamageCalculator damageCalculator)
        {
            _balance          = balance;
            _damageCalculator = damageCalculator;
        }
        
        public Rpg.Character CreateCharacter(string idCharacter)
        {
            Rpg.Character Character = null;

            if (_balance.PlayerBalance.TryGetValue(idCharacter, out var playerData))
            {
                Character = new Rpg.Character(playerData.Stats, _damageCalculator);
            }
            else if (_balance.EnemyBalance.TryGetValue(idCharacter, out var enemyData))
            {
                Character = new Rpg.Character(enemyData.Stats, _damageCalculator);

                foreach (string i in enemyData.AvailableWeapons)
                {
                    
                }
            }
            else { throw new Exception("Key not found"); }

            return Character;
        }
    }
}