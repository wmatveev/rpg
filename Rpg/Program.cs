using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using RPG.Character;
using RPG.Character.CharacterCreationFactory;
using RPG.Weapons;
using RPG.Weapons.DamageCalculation;

namespace Rpg
{

    public class CharactersFromJson
    {
        public Dictionary<string, Balance> Characters;

        // public void GenerationJSON()
        // {
        //     CharactersFromJson charactersFromJson = new CharactersFromJson()
        //     {
        //         Characters = new Dictionary<string, Stats>
        //         {
        //             ["Player1"] = new Stats()
        //             {
        //                 Power            = 5,
        //                 Energy           = 5,
        //                 Agility          = 5,
        //                 Endurance        = 5,
        //                 DamageProtection = 5,
        //                 MaxHealth        = 100
        //             },
        //             ["Enemy1"] = new Stats()
        //             {
        //                 Power            = 1,
        //                 Energy           = 1,
        //                 Agility          = 1,
        //                 Endurance        = 1,
        //                 DamageProtection = 1,
        //                 MaxHealth        = 10
        //             }
        //         }
        //     };
        //
        //     string json = JsonConvert.SerializeObject(charactersFromJson, Formatting.None);
        //     
        //     string path = @"c:\Users\matve\Documents\_dev\rpg\Rpg\json\MyJson.json";
        //     File.WriteAllText(path, json);
        // }
    }

    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            CharactersFromJson charactersFromJson = JsonConvert.DeserializeObject<CharactersFromJson>(File.ReadAllText(@"c:\Users\matve\Documents\_dev\rpg\Rpg\json\MyJson.json"));

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
