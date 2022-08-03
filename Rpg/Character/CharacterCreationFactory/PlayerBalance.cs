using System.Collections.Generic;

namespace RPG.Character.CharacterCreationFactory
{
    public class PlayerBalance
    {
        public Stats Stats;
    }

    // + тип поведения
    public class EnemyBalance
    {
        public Stats Stats;
    }

    public class Balance
    {
        public Dictionary<string, PlayerBalance> PlayerBalance;
        public Dictionary<string, EnemyBalance>  EnemyBalance;
    }

}