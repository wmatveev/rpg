using Rpg.Target;

namespace RPG.Weapons
{
    public class Rifle : IWeapon
    {
        public int CountCartridges { get; }
        public int IsReloading     { get; }
        public int Range           { get; }
        public bool CanShoot       { get; }

        public ITarget Shoot()
        {
            throw new System.NotImplementedException();
        }

        public void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}