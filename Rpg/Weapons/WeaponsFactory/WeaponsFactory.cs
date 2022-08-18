namespace RPG.Weapons.WeaponsFactory
{
    public class WeaponsFactory : IWeaponsFactory
    {
        public IWeapon CreateWeapon(string idWeapon)
        {
            return new Gun();
        }
    }
}