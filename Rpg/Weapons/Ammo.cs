namespace RPG.Weapons
{
    public class Ammo
    {
        private float _lead;         // Свинцовые патроны
        private float _fire;         // Возгорающиеся патроны
        private float _explosive;    // Разрывные патроны
        private float _shot;         // Дробь
        private float _tranquilizer; // Транквилизатор

        // Присваиваем повреждение патронам для пистолета
        public void BulletDamageForGun()
        {
            _lead = 0.4f;
            _fire = 0.7f;
        }
    }
}