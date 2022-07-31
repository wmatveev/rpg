using System;
using System.Collections.Generic;
using RPG.Character;
using RPG.Weapons;
// ReSharper disable All

namespace Rpg
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // // Создаем персонажа
            // Character mainCharacter = new Character();
            // mainCharacter.Health.Damageable(10);
            //
            // // Создаем противника
            // Character enemy = new Character();
            Stats stats = Stats.Default;
            Character testPlayerCharacter = new Character(ref stats);

            testPlayerCharacter.Health.DealDamage(50);
        }
    }

    public class Character
    {
        public int Level;

        public Stats Stats          { get; private set; }
        public IHealthStatus Health { get; private set; }

        // Список огнестрельного оружия, которым владеет персонаж
        public readonly Dictionary<TypesOfWeapons, Firearms> ListOfFirearms = new Dictionary<TypesOfWeapons, Firearms>();

        public Character(ref Stats stats)
        {
            // Создаем дефолтные статы персонажа
            Stats = stats;

            // Здоровье персонажа
            Health = new CharacterHealth(ref stats);
            
            // Добавляем оружие персонажу (пистолет)
            ListOfFirearms.Add( TypesOfWeapons.Gun, new Firearms() );
            ListOfFirearms[ TypesOfWeapons.Gun ].AaddingWeaponsToArsenal(TypesOfWeapons.Gun);
        }
    }
}
