using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class Player
    {
        public string playerName { get; set; }
        public int gameScore { get; set; }
        public int setScore { get; set; }
        public int setWin { get; set; }
        public bool advantageGame { get; set; }

        public bool advantageSet { get; set; }
        public bool gameWin { get; set; }

        public bool matchWin { get; set; }

        public Player()
        {

            this.gameScore = gameScore;
            this.setScore = setScore;
            advantageGame = false;
            advantageSet = false;
            gameWin = false;
            matchWin = false;
           
        }
        
      
       
    }
}
