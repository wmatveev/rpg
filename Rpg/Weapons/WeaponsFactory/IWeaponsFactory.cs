﻿namespace RPG.Weapons.WeaponsFactory
{
    public interface IWeaponsFactory
    {
        IWeapon CreateWeapon(string idWeapon);
    }
}