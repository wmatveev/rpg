using System;
using Stats;

namespace Damage
{
    public enum TypeDamage
    {
        MagicDamage    = 1,  // Магический урон
        PhysicalDamage = 2,  // Физический урон
        FireDamage     = 3,  // Огненный урон
        LightDamage    = 4   // Урон от света
    }

    public class CharacterDamage
    {
        private delegate void Death();
        private event Death EventOfDeath;
        
        private const int total_damage = 10;

        public CharacterDamage()
        {
            EventOfDeath += CharacterDeath;
        }
        
        // Получение урона с принадлежностью к стихии
        public void GetDamage(Enum e)
        {
            switch ( e )
            {
                case TypeDamage.MagicDamage:
                    CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.MagicDamage;
                    break;
                case TypeDamage.PhysicalDamage:
                    CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.PhysicalDamage;
                    break;
                case TypeDamage.FireDamage:
                    CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.FireDamage;
                    break;
                case TypeDamage.LightDamage:
                    CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.LightDamage;
                    break;
                
                default:
                    return ;
            }

            if ( CharacterStats.CurrHealth <= 0 )
            {
                if ( CharacterStats.ColLife == 1 )
                {
                    // TODO: вызвать событие для смерти персонажа
                    EventOfDeath();
                }
                else { CharacterStats.ColLife -= 1; }
            }
        }
        
        // Метод, где будет умирать персонаж
        private void CharacterDeath()
        {
            CharacterStats.IsAlive = false;
        }
    }
}