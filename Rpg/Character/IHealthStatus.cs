﻿using System;

namespace RPG.Character
{
    public interface IHealthStatus
    {
        event Action<Damage> OnDie;

        bool IsAlive       { get; }     // Возвращаем, жив ли персонаж
        int  MaxHealth     { get; }     // Возвращаем максимальное здоровье
        int  CurrentHealth { get; }     // Текущее здоровье

        float HealthAmount { get; }
        /// <summary>
        /// value 0..1 = CurrentHealth / MaxHealth 
        /// </summary>


        /// Нанести удар
        void DealDamage(Damage damage);
        
        /// Исцеляем повреждения
        void HealDamage(int amount);
        
        /// Мгновенная смерть
        void Death(Damage damage);
    }
}