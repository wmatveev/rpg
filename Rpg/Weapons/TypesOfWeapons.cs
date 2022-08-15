using System;

namespace RPG.Weapons
{
    public enum TypesOfWeapons : ushort
    {
        /// Винтовка
        Rifle = 1,
        
        /// Пистолет
        Gun = 2,
        
        /// Атомат
        AutomaticRifle = 3,
        
        /// Нож
        Knife = 4,
        
        /// Дробовик
        Shotgun = 5
    }
    
    public enum TypesOfCartridges : ushort
    {
        None = 0,
        /// Свинцовые патроны
        Lead = 1,
        
        /// Возгорающиеся патроны
        Fire = 2,
        
        /// Разрывные патроны
        Explosive = 3,
        
        /// Дробь
        Shot = 4,
        
        /// Транквилизатор
        Tranquilizer = 5
    }
}