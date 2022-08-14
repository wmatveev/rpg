using Rpg.Target;

namespace RPG.Weapons
{
    public interface IWeapon
    {
        int CountCartridges { get; }        // Количество патронов
        int IsReloading     { get; }        // В перезарядке
        int Range           { get; }        // Область, в которой можно стрелять
        bool CanShoot       { get; }        // Возможность стрелять

        ITarget Shoot();
        void Reload();
    }
}