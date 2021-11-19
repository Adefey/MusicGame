namespace MusicGame
{
    static class LevelFactory
    {
        public static int currentLevel;

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

        public static LevelData GetNext()
        {
            int n = currentLevel;
            if (currentLevel == 5)
            {
                currentLevel = 1;
            }
            else currentLevel++;
            return GetLevel(n);
        }
    }
}
