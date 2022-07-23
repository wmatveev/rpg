namespace RPG.Character
{
    public class CharacterStats
    {
        public int Power;            // Сила персонажа
        public int Level;            // Уровень персонажа
        public int Energy;           // Енергия персонажа
        public int Agility;          // Ловкость персонажа
        public int Endurance;        // Выносливость персонажа
        public int DamageProtection; // Защита от урона

        // Персонаж с дефолтными значениями
        public CharacterStats()
        {
            Power      = (int)DefaultStatsValue.Power;
            Level      = (int)DefaultStatsValue.Level;
            Energy     = (int)DefaultStatsValue.Energy;
            Agility    = (int)DefaultStatsValue.Agility;
            Endurance  = (int)DefaultStatsValue.Endurance;
            DamageProtection = (int)DefaultStatsValue.DamageProtection; 
        }
    }
}