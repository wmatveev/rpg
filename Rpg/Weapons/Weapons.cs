using System;
using System.Collections.Generic;

namespace RPG.Weapons
{
    public abstract class Weapons
    {
        protected int FiringRange;       // Дальность стрельбы
        protected int FiringAccuracy;    // Точность стрельбы
        protected int Grouping;          // Кучность стрельбы
        protected int CountOfShots;      // Количество (выстрелов/бросков) за раз
        private static int _damage;      // Общий урон за выстрел

        protected int CountOfCartridges; // Количество (патронов/холодного оружия)

        // protected float ShotDamage;      // Урон от выстрела


        // Создаем коэффициент урона для каждого типа оружия
        protected Dictionary<TypesOfWeapons, float> DamageCoefOfWeaponType = new Dictionary<TypesOfWeapons, float>();

        // Создаем коэффициент урона для каждого типа патрона
        protected Dictionary<TypesOfCartridges, float> DamageCoefOfCartridgeType = new Dictionary<TypesOfCartridges, float>();

        // protected List<CoefOfWeaponType> DamageCoefOfWeaponType =
        //     new List<CoefOfWeaponType>
        //     {
        //         new CoefOfWeaponType { Weapon = TypesOfWeapons.Rifle, Coef = 0.2f },
        //         new CoefOfWeaponType { Weapon = TypesOfWeapons.Rifle, Coef = 0.4f }
        //     };

        public abstract void  GetDamage();
        public abstract float Shoot();

        protected Weapons()
        {
            // Инициализируем общий урон за выстрел
            _damage = 10;
            
            // Инициализируем урон для каждого типа оружия
            DamageCoefOfWeaponType.Add(TypesOfWeapons.Rifle,          0.4f);
            DamageCoefOfWeaponType.Add(TypesOfWeapons.Gun,            0.2f);
            DamageCoefOfWeaponType.Add(TypesOfWeapons.AutomaticRifle, 0.3f);
            DamageCoefOfWeaponType.Add(TypesOfWeapons.Knife,          0.1f);
            DamageCoefOfWeaponType.Add(TypesOfWeapons.Shotgun,        0.6f);
            
            // Инициализируем урон для каждого типа патрона
            DamageCoefOfCartridgeType.Add(TypesOfCartridges.Lead,         0.2f);
            DamageCoefOfCartridgeType.Add(TypesOfCartridges.Fire,         0.4f);
            DamageCoefOfCartridgeType.Add(TypesOfCartridges.Explosive,    0.6f);
            DamageCoefOfCartridgeType.Add(TypesOfCartridges.Shot,         0.6f);
            DamageCoefOfCartridgeType.Add(TypesOfCartridges.Tranquilizer, .0f);
        }
        
        public static int ShotDamageCalculation(int Damage, TypesOfWeapons typesOfWeapons, TypesOfCartridges typesOfCartridges)
        {
            // Считаем урон от выстрела
            // Урон = общий урон от выстрела * (коэф. от оружия + коэф. от патрона + TODO коэф-ты зависящие от растояния до Enemy)
            // return (int)( _damage * (DamageCoefOfWeaponType[typesOfWeapons] + DamageCoefOfCartridgeType[typesOfCartridges]) );

            return 0;
        }

    }
}