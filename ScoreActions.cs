using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public class ScoreActions
    {
        public static void addGameScore(Player p)
        {
            bool nextSet = false;

            switch (p.gameScore)
            {
                case 0:
                    p.gameScore = 15;
                    break;

                case 15:
                    p.gameScore = 30;
                    break;

                case 30:
                    p.gameScore = 40;
                    if (PropertyCollection.P1.gameScore == 40 && PropertyCollection.P1.gameScore == PropertyCollection.P2.gameScore)
                    {
                        PropertyCollection.deuce = true;
                    }
                    break;
                case 40:

                    if (PropertyCollection.deuce)
                    {
                        if (PropertyCollection.gameAdvantage == null)
                        {
                            p.advantageGame = true;
                            PropertyCollection.gameAdvantage = p;

                        }
                        else if (PropertyCollection.gameAdvantage == p)
                        {
                            nextSet = true;
                            PropertyCollection.deuce = false;
                        }
                        else
                        {
                            PropertyCollection.gameAdvantage = null;
                            p.advantageGame = false;
                        }

                    }
                    else
                        nextSet = true;

                    break;
            }

            if (nextSet)
            {

                updateSetScore(p);

                clearGameScore();

               
            }

        }

        public static void clearGameScore()
        {
            PropertyCollection.P1.gameScore = 0;
            PropertyCollection.P2.gameScore = 0;
            //PropertyCollection.gameInference = "";
            PropertyCollection.P1.advantageSet = false;
            PropertyCollection.P2.advantageSet = false;
            PropertyCollection.deuce = false;


        }


        public static void clearGameInference()
        {
            PropertyCollection.gameInference = "";
        }

        public static void updateSetScore(Player p)
        {
            p.setScore++;


            if (p == PropertyCollection.P1 && p.setScore>=6)
            {
                if (PropertyCollection.P2.setScore < p.setScore)
                {
                    PropertyCollection.P1.setWin++;
                    PropertyCollection.gameInference = "Player 1 wins SET";
                    PropertyCollection.totalSets++;
                    clearSetScore();
                }

            }
            else if(p == PropertyCollection.P2 && p.setScore >= 6)
            {
                if (PropertyCollection.P1.setScore < p.setScore)
                {
                    PropertyCollection.P2.setWin++;
                    PropertyCollection.gameInference = "Player 2 wins SET";
                    PropertyCollection.totalSets++;
                    clearSetScore();
                }


            }
            if (PropertyCollection.totalSets >= 3)
            {
                setMatchWin();
                setGameInference();
            }

        }

        public static void setGameInference()
        {


            //based on game Score
            string P1Score = Convert.ToString(PropertyCollection.P1.gameScore);
            string P2Score = Convert.ToString(PropertyCollection.P2.gameScore);

            if(P1Score == "0")
            {
                P1Score = "Love";
            }
            if (P2Score == "0")
            {
                P2Score = "Love";
            }

            if (PropertyCollection.P1.gameScore == PropertyCollection.P2.gameScore)
            {
                if (PropertyCollection.deuce)
                {

                    if (PropertyCollection.P1.advantageGame && PropertyCollection.gameAdvantage == PropertyCollection.P1)
                    {
                        PropertyCollection.gameInference = "Player 1 at advantage";
                    }
                    else if (PropertyCollection.P2.advantageGame && PropertyCollection.gameAdvantage == PropertyCollection.P2)
                    {
                        PropertyCollection.gameInference = "Player 2 at advantage";
                    }
                    else
                        PropertyCollection.gameInference = "Deuce";
                }
                else
                {
                    PropertyCollection.gameInference = P1Score + " - all";
                }

            }
            else
            {
                PropertyCollection.gameInference = P1Score + "-" + P2Score;
            }


            //Based on Set
           



            if (PropertyCollection.P1.advantageSet)
            {
                PropertyCollection.gameInference = "Player 1 at set advantage";
            }
            if (PropertyCollection.P2.advantageSet)
            {
                PropertyCollection.gameInference = "Player 2 at set advantage";
            }
            if (PropertyCollection.tie)
            {
                PropertyCollection.gameInference = "Its a tie";
            }
            if (PropertyCollection.P1.matchWin)
            {
                PropertyCollection.gameInference = "Player 1 wins match";
            }
            if (PropertyCollection.P2.matchWin)
            {
                PropertyCollection.gameInference = "Player 2 wins match";
            }
            if (PropertyCollection.P1.gameWin)
            {
                PropertyCollection.gameInference = "Player 1 wins Game";
            }
            if (PropertyCollection.P2.gameWin)
            {
                PropertyCollection.gameInference = "Player 2 wins Game";
            }
        }

        public static void clearSetScore()
        {
            PropertyCollection.P1.setScore = 0;
            PropertyCollection.P2.setScore = 0;
            PropertyCollection.tie = false;
            PropertyCollection.gameInference = "";


        }

        public static void setMatchWin()
        {
            int compare = PropertyCollection.P1.setWin - PropertyCollection.P2.setWin;
            if (compare > 1)
            {
                PropertyCollection.P1.matchWin = true;
                PropertyCollection.endGame = true;
                //MainPage.disableScoring();
            }
            else if (compare < -1)
            {
                PropertyCollection.P2.matchWin = true;
                PropertyCollection.endGame = true;
                //MainPage.disableScoring();
            }
            else if (compare == 0 && PropertyCollection.P1.setWin != 0)
            {
                PropertyCollection.tie = true;

            }
            else if (compare == 1)
            {
                PropertyCollection.P1.advantageSet = true;
            }
            else if (compare == -1)
            {
                PropertyCollection.P2.advantageSet = true;
            }
        }

    }
}
