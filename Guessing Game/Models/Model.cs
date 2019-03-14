using System;
using System.Collections;

namespace Guessing_Game.Models
{
    public class RandomModel
    {
        private static Random Rnd = new Random();
        private static ArrayList RandomNumbers = new ArrayList();

        public static void AddNumber()
        {
            RandomNumbers.Add(Rnd.Next(1, 101));
        }

        public static int GetSize()
        {
            return RandomNumbers.Count - 1;
        }

        public static int GetNumber(int sessionId)
        {
            return Convert.ToInt32(RandomNumbers[sessionId]);
        }

    }
}