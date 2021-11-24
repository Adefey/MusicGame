namespace MusicGame
{
    static class LevelFactory
    {
        public static int currentLevel = 1;
        private static int currentLocalLevel = 1; 
        public static int maxLevel;

        public static LevelData GetLevel(int levelNum)
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

        public static void SetStart()
        {
            currentLocalLevel = 1;
        }

        public static LevelData GetNext()
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
