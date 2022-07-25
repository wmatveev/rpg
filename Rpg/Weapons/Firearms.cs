using System.Collections.Generic;

namespace RPG.Weapons
{
    // Огнестрельное оружие
    public class Firearms : Weapons
    {
        private Dictionary<TypesOfWeapons, bool> _listOfAvailableWeapons = new Dictionary<TypesOfWeapons, bool>();

        // Добавляем новое оружие в арсенал
        public void AaddingWeaponsToArsenal(TypesOfWeapons typesOfWeapons)
        {
            if( !_listOfAvailableWeapons.ContainsKey(typesOfWeapons) )
                _listOfAvailableWeapons.Add(typesOfWeapons, true);
        }

        public override void GetDamage()
        {
            
        }

        // Возвращаем урон при выстреле
        public override float Shoot()
        {
            return .0f;
        }
    }
}