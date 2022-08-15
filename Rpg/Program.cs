using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Rpg.Attack;
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

            // IGetBalans getBalans = new GetCharactersBalans("MyJson.json");
            // getBalans.CreateJsonBalansFromExample();
            
            Balance balance = new GetCharactersBalans("MyJson.json").GetBalans();
            
            ICharatersFactory MainCharacter = new CharactersFactory(balance, new DamageCalculator());
            
            Character Player = MainCharacter.CreateCharacter("Player1");
            Character Enemy1  = MainCharacter.CreateCharacter("Enemy1");
            Character Enemy2  = MainCharacter.CreateCharacter("Enemy2");


            IAttack Attack = new Attack.Attack();
            Attack.CharacterAttack(Player, Enemy1);
        }
    }

    public class Character
    {
        public int Level;

        public Stats Stats          { get; private set; }
        public IHealthStatus Health { get; private set; }

        public IWeaponController WeaponController;

        // Список огнестрельного оружия, которым владеет персонаж
        // public readonly Dictionary<TypesOfWeapons, Firearms> ListOfFirearms = new Dictionary<TypesOfWeapons, Firearms>();

        public Character(Stats stats, IDamageCalculator damageCalculator)
        {
            Stats = stats;
            
            // Здоровье персонажа
            Health = new CharacterHealth(stats, damageCalculator);

            // Добавляем оружие персонажу (пистолет)
            WeaponController = new WeaponController();
            WeaponController.AddWeaponToCharacter(new Gun(10, 100, 5));
        }
    }
}
