using System;
using System.Collections.Generic;
using RPG.Character;
using RPG.Weapons;

namespace Rpg
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Создаем персонажа
            CharacterCreator mainCharacter = new CharacterCreator();
            mainCharacter.Health.Damageable(10);
            
            // Создаем противника
            CharacterCreator enemy = new CharacterCreator();
        }
    }

    public class CharacterCreator
    {
        public CharacterStats  Character;
        public CharacterHealth Health;

        // Список огнестрельного оружия, которым владеет персонаж
        public readonly Dictionary<TypesOfWeapons, Firearms> ListOfFirearms = new Dictionary<TypesOfWeapons, Firearms>();

        public CharacterCreator()
        {
            // Создаем дефолтные статы персонажа
            Character = new CharacterStats();

            // Здоровье персонажа
            Health = new CharacterHealth(Character);
            
            // Добавляем оружие персонажу (пистолет)
            ListOfFirearms.Add( TypesOfWeapons.Gun, new Firearms() );
            ListOfFirearms[ TypesOfWeapons.Gun ].AaddingWeaponsToArsenal(TypesOfWeapons.Gun);
        }
    }
}
