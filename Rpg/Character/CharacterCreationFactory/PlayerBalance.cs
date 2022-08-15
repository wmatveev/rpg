using System.Collections.Generic;
using RPG.Weapons;

namespace RPG.Character.CharacterCreationFactory
{
    public class PlayerBalance
    {
        public Stats Stats;
        public WeaponController WeaponController;
    }

    // + тип поведения
    public class EnemyBalance
    {
        public Stats Stats;
        public WeaponController WeaponController;
    }

    public class Balance
    {
        public Dictionary<string, PlayerBalance> PlayerBalance;
        public Dictionary<string, EnemyBalance>  EnemyBalance;
    }

}