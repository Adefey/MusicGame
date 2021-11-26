namespace MusicGame
{
    static class LevelFactory //Это класс для вызова уровня по номеру и по порядку
    {
        public static int currentLevel = 1;
        private static int currentLocalLevel = 1; 
        public static int maxLevel;

        public static LevelData GetLevel(int levelNum) //Вызвать уровень по номеру
        {
            switch (levelNum)
            {
                case 1: return new LevelOneData();
                case 2: return new LevelTwoData();
                case 3: return new LevelThreeData();
                case 4: return new LevelFourData();
                case 5: return new LevelFiveData();
                default: return null;
            }
        }

        public static void SetStart() //Задать начальный уровень
        {
            currentLocalLevel = 1;
        }

        public static LevelData GetNext() //Вызов следующего уровня. Счетчик - статическая переменная, поэтому работает.
        {
            int n = currentLocalLevel;
            currentLevel = currentLocalLevel;
            if (currentLocalLevel == maxLevel)
            {
                currentLocalLevel = 1;
            }
            else currentLocalLevel++;
            return GetLevel(n);
        }
    }
}
