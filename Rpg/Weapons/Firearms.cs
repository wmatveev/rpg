using System.Collections.Generic;

namespace RPG.Weapons
{
    // Огнестрельное оружие
    public class Firearms : Weapons
    {
        public ushort TypeOfWeapon;

        // Создаем список для хранения типов патронов при создании оружия
        private readonly List<Ammo> _ammo = new List<Ammo>();
        
        
        // Добавляем пистолет с значениями по умолчанию
        public void AddGun()
        {
            Firearms _firearms = new Firearms();
            
            _firearms.CountOfAmmo    = 100;     // Количество патронов 100
            _firearms.FiringRange    = 70;      // Дальность стрельбы 70 метров
            _firearms.FiringAccuracy = 100;     // TODO точность сдалать зависимость от растояния до противника
            _firearms.Grouping       = 100;     // Кучность стрельбы 100% у пистолета
            _firearms.CountOfShots   = 1;       // Один выстрел за раз

            _ammo.Add(new Ammo());
            _ammo[0].BulletDamageForGun();
        }

        public override void GetDamage()
        {
            
        }

        public override void Shoot()
        {
            
        }
    }
}