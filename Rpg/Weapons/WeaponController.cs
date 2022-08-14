using System.Collections.Generic;

namespace RPG.Weapons
{
    public class WeaponController : IWeaponController
    {
        public List<IWeapon> listOfWeapons { get; }
        public IWeapon CurrentWeapon { get; private set; }

        public WeaponController()
        {
            listOfWeapons = new List<IWeapon>();
        }

        // Добавляем оружие в список, которым владеет персонаж
        public void AddWeaponToCharacter(IWeapon weapon)
        {
            listOfWeapons.Add(weapon);

            // Когда добавляем персонажу новое оружие, сразу делаем его активным
            CurrentWeapon = weapon;
        }

        // Удаляем оружие из списка, которым владеет персонаж
        public void DropWeaponFromCharacter(IWeapon weapon)
        {
            listOfWeapons.Remove(weapon);
            CurrentWeapon = listOfWeapons.Count != 0 ? listOfWeapons[0] : null;
        }

        // Функция выбора оружия
        public void SelectWeapon(int index)
        {
            throw new System.NotImplementedException();
        }
    }
}