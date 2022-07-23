using System;

namespace RPG.Character
{
    public class CharacterHealth
    {
        private int _amountOfHealth; // Количество здоровья
        
        public delegate void Death();
        // TODO раскоментировать позже public event Death EventOfDeath;
        
        public CharacterHealth(CharacterStats characterStats)
        {
            // EventOfDeath += CharacterDeath;
            // _characterStats = characterStats;
        }

        // Получение урона
        public void Damageable(int amountOfDamage)
        {
            _amountOfHealth -= amountOfDamage; // Уменьшаем количество здоровья на сумму урона
        }
        
        // Метод, где будет умирать персонаж
        private void CharacterDeath()
        {
            // CharacterStats.IsAlive = false;
        }
    }
}