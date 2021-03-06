using System;

namespace RPG.Weapons
{
    public enum TypesOfWeapons : ushort
    {
        Rifle          = 1,     // Винтовка
        Gun            = 2,     // Пистолет
        AutomaticRifle = 3,     // Атомат
        Knife          = 4,     // Нож
        Shotgun        = 5      // Дробовик
    }
    
    public enum TypesOfCartridges : ushort
    {
        Lead         = 1,   // Свинцовые патроны
        Fire         = 2,   // Возгорающиеся патроны
        Explosive    = 3,   // Разрывные патроны
        Shot         = 4,   // Дробь
        Tranquilizer = 5    // Транквилизатор
    }
    
}