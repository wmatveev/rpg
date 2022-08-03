using RPG.Character;

namespace RPG.Weapons.DamageCalculation
{
    public class TestDamageCalculator : IDamageCalculator
    {
        public int GetDamage(Damage damage, Stats stats)
        {
            return damage.Amount;
        }
    }
}