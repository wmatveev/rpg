using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Rpg.Balans;
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
            Balance balance = new GetCharactersBalans().GetBalans();
            
            ICharatersFactory MainCharacter = new CharactersFactory(balance, new TestDamageCalculator());
            
            var Player = MainCharacter.CreateCharacter("Player1");
            var Enemy  = MainCharacter.CreateCharacter("Enemy1");
        }
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
