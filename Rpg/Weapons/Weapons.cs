namespace RPG.Weapons
{
    public abstract class Weapons
    {
        protected ushort FiringRange;       // Дальность стрельбы
        protected ushort FiringAccuracy;    // Точность стрельбы
        protected ushort Grouping;          // Кучность стрельбы
        protected ushort CountOfShots;      // Количество (выстрелов/бросков) за раз

        protected ushort CountOfAmmo;       // Количество (патронов/холодного оружия)

        public abstract void GetDamage();
        public abstract void Shoot();
    }
}