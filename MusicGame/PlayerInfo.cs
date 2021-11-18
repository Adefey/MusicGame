using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
