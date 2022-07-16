namespace Stats
{

    public class CharacterStats
    {
        private static int _colLife = 10;             // Количество жизней
        private static bool _isAlive = true;

        private static int _currLife;         // Текущая жизнь
        private static int _currHealth;       // Текущее здоровье
        private static int _power;            // Сила персонажа
        private static int _level;            // Уровень персонажа
        private static int _energy;           // Енергия персонажа
        private static int _agility;          // Ловкость персонажа
        private static int _endurance;        // Выносливость персонажа
        private static int _damageProtection; // Защита от урона

        public static int CurrHealth
        {
            get => _currHealth;
            set => _currHealth = value;
        }

        public static int ColLife
        {
            get => _colLife;
            set => _colLife = value;
        }

        public static bool IsAlive
        {
            get => _isAlive;
            set => _isAlive = value;
        }

        
        // Рождение персонажа в начале игры или при загрузке
        public CharacterStats(int curr_life, int currHealth, int power, int level, int energy, 
            int agility, int endurance, int damage_protection)
        {
            CharacterStats._currLife   = curr_life;
            CharacterStats._currHealth = currHealth;
            CharacterStats._power      = power;
            CharacterStats._level      = level;
            CharacterStats._energy     = energy;
            CharacterStats._agility    = agility;
            CharacterStats._endurance  = endurance;
            CharacterStats._damageProtection = damage_protection;
        }
    }
}