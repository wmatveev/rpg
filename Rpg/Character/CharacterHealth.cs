using System;

namespace RPG.Character
{
    public class CharacterHealth
    {
        public int chHealth; // Текущее здоровье
        
        private CharacterStats _characterStats;
        
        public delegate void Death();
        public event Death EventOfDeath;
        
        private const int total_damage = 10;

        public CharacterHealth(CharacterStats characterStats)
        {
            // EventOfDeath += CharacterDeath;
            _characterStats = characterStats;
        }
        
        
        // Получение урона с принадлежностью к стихии
        public void GetDamage(TypeDamage e)
        {
            // switch ( e )
            // {
            //     case TypeDamage.MagicDamage:
            //         CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.MagicDamage;
            //         break;
            //     case TypeDamage.PhysicalDamage:
            //         CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.PhysicalDamage;
            //         break;
            //     case TypeDamage.FireDamage:
            //         CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.FireDamage;
            //         break;
            //     case TypeDamage.LightDamage:
            //         CharacterStats.CurrHealth -= total_damage * (int)TypeDamage.LightDamage;
            //         break;
            //     
            //     default:
            //         return ;
            // }
            //
            // if ( CharacterStats.CurrHealth <= 0 )
            // {
            //     if ( CharacterStats.ColLife == 1 )
            //     {
            //         // TODO: вызвать событие для смерти персонажа
            //         EventOfDeath();
            //     }
            //     else
            //     {
            //         CharacterStats.ColLife -= 1;
            //         CharacterStats.CurrHealth = 1000;
            //     }
            // }
        }
        
        // Метод, где будет умирать персонаж
        private void CharacterDeath()
        {
            // CharacterStats.IsAlive = false;
        }
    }
}