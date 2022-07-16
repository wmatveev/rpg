using System;
using Stats;
using Damage;

namespace Rpg
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            CharacterStats character = new CharacterStats(1, 1000, 1, 1, 1, 
                1, 1, 1);

            CharacterDamage dmg = new CharacterDamage();
            dmg.GetDamage(Damage.TypeDamage.FireDamage);
        }

    }
}
