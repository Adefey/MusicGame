namespace MusicGame
{
    static class PlayerInfo
    {
        private static int maxHP = 5;

        public static string name = "";
        public static int difficulty = 1;
        public static int score = 0;
        public static int HP = maxHP;
        public static int currentStage = 0;
        //0 - menu, 1 - first stage ...

        public static void Revive()
        {
            HP = maxHP;
        }

        public static void SetPlayer(string newName, int newDifficulty)
        {
            name = newName;
            difficulty = newDifficulty;
        }

        public static void ForgetPlayer()
        {
            name = "";
            difficulty = 1;
            score = 0;
            HP = maxHP;
            currentStage = 0;
        }

        public static bool IsReady()
        {
            if (name != "" && currentStage == 0 && HP == maxHP && score == 0)
                return true;
            return false;
        }
    }
}
