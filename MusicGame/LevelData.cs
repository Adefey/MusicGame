using System.Collections.Generic;

namespace MusicGame
{
    class LevelData //Базовые данные об уровне.
    {
        public List<int> notes; //Сюда пишутся ноты (от 0 до 6).
        public int delay; //Сюда пишется задержка между нотами. Не пишите число меньше 250, так как одна нота звучит 200. Задержка между нотами всегда одинакова, можно бы было сделать массив разных задержек, больше клавиш, выбор инструментов, но за такие сжатые сроки не получилось
        public static int count = 0; //Если честно, я забыл что это. Наверное можно убрать. Возможно, это счетчик уровней, а он сейчас в LevelFactory
    }

    class LevelOneData : LevelData
    {
        public LevelOneData() //Данные для 1 уровня. В комментарии дальше написаны 2 мелодии, которые можно использовать.
        {
            notes = new List<int> { 1, 2, 3 }; //В лесу родилас елочка   0, 5, 5, 4, 5, 3, 0, 0 ..3, 3, 4, 3, 6, 5, 3, 3, 4, 3, 6
            delay = 400;
            count = 0; //Также можно использовать свою мелодию, составив ее из чисел от 0 до 6.
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
