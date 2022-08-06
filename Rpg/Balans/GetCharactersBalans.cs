using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPG.Character;
using RPG.Character.CharacterCreationFactory;

namespace Rpg.Balans
{
    public class GetCharactersBalans : IGetBalans
    {
        public Balance GetBalans()
        {
            Balance balance = JsonConvert.DeserializeObject<Balance>(File.ReadAllText(@"MyJson.json"));

            return balance;
        }

        public void CreateJsonBalansFromExample()
        {
            Balance balance = new Balance() {
                PlayerBalance = new Dictionary<string, PlayerBalance>() {
                    ["Player1"] = new PlayerBalance() {
                        Stats = Stats.Default 
                    }
                },
                EnemyBalance  = new Dictionary<string, EnemyBalance>() {
                    ["Enemy1"] = new EnemyBalance() {
                        Stats = Stats.Default }
                }
            };
            
            string json = JsonConvert.SerializeObject(balance, Formatting.Indented);
            
            string path = @"MyJson.json";
            File.WriteAllText(path, json);
        }
    }
}