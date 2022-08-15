using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RPG.Character;
using RPG.Character.CharacterCreationFactory;
using RPG.Weapons;

namespace Rpg.Balans
{
    public class GetCharactersBalans : IGetBalans
    {
        private string _path;
        
        public GetCharactersBalans(string Path)
        {
            _path = Path;
        }

        public Balance GetBalans()
        {
            // TODO сделать через конструктор
            return JsonConvert.DeserializeObject<Balance>(File.ReadAllText(_path));
        }

        public void CreateJsonBalansFromExample()
        {
            Balance balance = new Balance() {
                PlayerBalance = new Dictionary<string, PlayerBalance>() {
                    ["Player1"] = new PlayerBalance() {
                        Stats = Stats.Default,
                        // WeaponController = WeaponController.DefaultForPlayer 
                    }
                },
                EnemyBalance  = new Dictionary<string, EnemyBalance>() {
                    ["Enemy1"] = new EnemyBalance() {
                        Stats = Stats.Default,
                        // WeaponController = WeaponController.DefaultForEnemy
                    }
                }
            };

            string json = JsonConvert.SerializeObject(balance, Formatting.Indented);

            string path = @"MyJson.json";
            File.WriteAllText(path, json);
        }
    }
}