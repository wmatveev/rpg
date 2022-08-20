using System;
using System.Linq;
using RPG.Weapons;
using RPG.Weapons.DamageCalculation;
using RPG.Weapons.WeaponsFactory;

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

                WeaponsFactory weaponsFactory = new WeaponsFactory(_balance);

                // Бежим по списку оружия из json и создаем его
                foreach (string i in playerData.AvailableWeapons) {
                    IWeapon weapon = weaponsFactory.CreateWeapon(i);

                    if( weapon != null) {
                        Character.Weapons.Add( i, weapon );
                        Character.WeaponController.AddWeaponToCharacter(weapon);
                    }
                }
            }
            else if (_balance.EnemyBalance.TryGetValue(idCharacter, out var enemyData))
            {
                Character = new Rpg.Character(enemyData.Stats, _damageCalculator);

                WeaponsFactory weaponsFactory = new WeaponsFactory(_balance);

                // Бежим по списку оружия из json и создаем его
                foreach (string i in enemyData.AvailableWeapons) {
                    IWeapon weapon = weaponsFactory.CreateWeapon(i);

                    if( weapon != null) {
                        Character.Weapons.Add( i, weapon );
                        Character.WeaponController.AddWeaponToCharacter(weapon);
                    }
                }
            }
            else { throw new Exception("Key not found"); }

            return Character;
        }
    }
}