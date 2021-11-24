using System.Collections.Generic;

namespace MusicGame
{
    class LevelData
    {
        public List<int> notes;
        public int delay;
        public static int count = 0;
    }

    class LevelOneData : LevelData
    {
        public LevelOneData()
        {
            notes = new List<int> { 1, 2, 3 }; //В лесу родилас елочка   0, 5, 5, 4, 5, 3, 0, 0 ..3, 3, 4, 3, 6, 5, 3, 3, 4, 3, 6
            delay = 400;
            count = 0;
        }
    }

    class LevelTwoData : LevelData
    {
        public LevelTwoData()
        {
            notes = new List<int> { 2, 5, 5, 5, 6, 5 }; //Песня гены 2, 5, 5, 5, 6, 5, 4, 5, 4, 3, 3 ..4, 3, 2, 1, 5, 5, 4, 6, 6, 4, 3, 5, 5, 3, 2, 3, 4, 2, 1, 1
            delay = 375;
            count = 0;
        }
    }

    class LevelThreeData : LevelData
    {
        public LevelThreeData()
        {
            notes = new List<int> { 5, 4, 4, 5, 3, 3 }; //Антонио 5, 4, 4, 5, 3, 3, 5, 4, 4, 2, 0, 5, 3
            delay = 350;
            count = 0;
        }
    }

    class LevelFourData : LevelData
    {
        public LevelFourData()
        {
            notes = new List<int> { 4, 4, 5, 5, 2, 2, 4 }; //Утята 4, 4, 5, 5, 2, 2, 4, 4, 4, 5, 5, 2, 2, 4
            delay = 325;
            count = 0;
        }
    }

    class LevelFiveData : LevelData
    {
        public LevelFiveData()
        {
            notes = new List<int> { 0, 2, 4, 5, 5, 4, 2, 3 }; //Фиксики 0, 2, 4, 5, 5, 5, 4, 2, 2, 2, 3, 2, 1
            delay = 300;
            count = 0;
        }
    }

}
