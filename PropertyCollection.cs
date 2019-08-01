using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class PropertyCollection
    {
        public static Player P1 { get; set; }
        public static Player P2 { get; set; }

        public static string gameInference {get;set;}

        public static bool tie { get; set; }

        public static bool deuce { get; set; }

        public static Player gameAdvantage { get; set; }

        public static int totalSets { get; set; }

        public static bool endGame { get; set; }

        public static void resetGame()
        {
            P1 = new Player();
            P2 = new Player();
            gameInference = "";
            tie = false;
            deuce = false;
            gameAdvantage = null;
            totalSets = 0;
            endGame = false;
        }
    }
}
