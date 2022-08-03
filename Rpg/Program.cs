using System;
using System.Collections.Generic;
using System.Diagnostics;
using RPG.Character;
using RPG.Character.CharacterCreationFactory;
using RPG.Weapons;
using RPG.Weapons.DamageCalculation;

namespace Rpg
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Balance balance = new Balance()
            {
                PlayerBalance = new Dictionary<string, PlayerBalance>()
                {
                    ["Player1"] = new PlayerBalance()
                    {
                        Stats = Stats.Default 
                    }
                },
                EnemyBalance  = new Dictionary<string, EnemyBalance>()
                {
                    ["Enemy1"] = new EnemyBalance()
                    {
                        Stats = Stats.Default
                    }
                }
            };
            
            CharactersFactory MainCharacter = new CharactersFactory(balance, new TestDamageCalculator());

            var Player = MainCharacter.CreateCharacter("Player1");
            var Enemy  = MainCharacter.CreateCharacter("Enemy1");


        }
    }

    internal class CreateCharacter
    {
    }

    public class Character
    {
        public int Level;

        public Stats Stats          { get; private set; }
        public IHealthStatus Health { get; private set; }

        // Список огнестрельного оружия, которым владеет персонаж
        public readonly Dictionary<TypesOfWeapons, Firearms> ListOfFirearms = new Dictionary<TypesOfWeapons, Firearms>();

        public Character(Stats stats, IDamageCalculator damageCalculator)
        {
            // Здоровье персонажа
            Health = new CharacterHealth(stats, damageCalculator);
            
            // Добавляем оружие персонажу (пистолет)
            ListOfFirearms.Add( TypesOfWeapons.Gun, new Firearms() );
            ListOfFirearms[ TypesOfWeapons.Gun ].AaddingWeaponsToArsenal(TypesOfWeapons.Gun);
        }
    }
}
