namespace MusicGame
{
    static class PlayerInfo //Данные об игроке
    {
        private static int maxHP = 5; //Изначально планировалось ввести максимальное здоровье и за каждую ошибку его уменьшать, но сейчас это не используется, можно удалить

        public static string name = ""; //Имя игрока
        public static int difficulty = 1; //Сложность от 3 до 5 вроде
        public static int score = 0; //Очки, здесь не используются, а зря. Можно удалить
        public static int HP = maxHP; //не используется
        public static int currentStage = 0;
        //0 - menu, 1 - first stage ...

        public static void Revive() //Оживить игрока - не используется
        {
            HP = maxHP;
        }

        public static void SetPlayer(string newName, int newDifficulty) //Настройка игрока
        {
            name = newName;
            difficulty = newDifficulty+2;
        }

        public static void ForgetPlayer() //Забыть игрока
        {
            name = "";
            difficulty = 1;
            score = 0;
            HP = maxHP;
            currentStage = 0;
        }

        public static bool IsReady() //ПРоверка на готовность
        {
            if (name != "" && currentStage == 0 && HP == maxHP && score == 0)
                return true;
            return false;
        }
    }
}
