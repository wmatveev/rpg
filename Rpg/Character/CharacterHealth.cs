using System;

namespace RPG.Character
{
    public interface IHealthStatus
    {
        event Action OnDie;

        bool IsAlive       { get; }     // Возвращаем, жив ли персонаж
        int  MaxHealth     { get; }     // Возвращаем максимальное здоровье
        int  CurrentHealth { get; }     // Текущее здоровье
        /// <summary>
        /// value 0..1 = CurrentHealth / MaxHealth 
        /// </summary>

        void DealDamage(int amount);    // Нанести удар
        void HealDamage(int amount);    // Исцеляем повреждения
        void Death();                   // Мгновенная смерть
    }
    
    public class CharacterHealth : IHealthStatus
    {
        public event Action OnDie;
        
        public int  MaxHealth     => _stats.MaxHealth;
        public int  CurrentHealth => _stats.MaxHealth - _injuries;
        public float HealthAmount => (float)CurrentHealth / MaxHealth;

        public bool  IsAlive      { get; private set; }

        private int   _injuries; // Количество здоровья
        private Stats _stats;
        
        
        public CharacterHealth(ref Stats Stats)
        {
            _stats = Stats;
        }

        // Получение урона
        public void Damageable(int amountOfDamage)
        {
            // _injuries -= amountOfDamage; // Уменьшаем количество здоровья на сумму урона
        }
        
        /// Нанести удар
        public void DealDamage(int amount)
        {
            _injuries += amount;
            if (_injuries > MaxHealth)
                Death();
        }

        /// Исцеляем повреждения
        public void HealDamage(int amount)
        {
            _injuries -= amount;
            if (_injuries < 0)
                _injuries = 0;
        }

        /// Смерть персонажа
        public void Death()
        {
            IsAlive = false;

            OnDie?.Invoke();
            // if (OnDie != null)
            //     OnDie();

        }
    }
}