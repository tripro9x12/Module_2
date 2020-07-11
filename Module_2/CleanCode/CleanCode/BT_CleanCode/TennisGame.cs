using System;
using System.Collections.Generic;
using System.Text;

namespace BT_CleanCode
{
    public class TennisGame
    {
       
        const int Love = 0;
        const int Fifteen = 1;
        const int Thirty = 2;
        const int Forty = 3;
        const int Num = 4;


        /// <summary>
        ///so sánh 2 num score bằng nhau, kết quả trả về là 1 string
        /// </summary>
        /// <param int name="NumScoreOne"></param>
        private static string GetNumEquals(int NumScoreOne)
        {
            string score = "";
            switch (NumScoreOne)
            {
                case Love:
                    score = "Love-All";
                    break;
                case Fifteen:
                    score = "Fifteen-All";
                    break;
                case Thirty:
                    score = "Thirty-All";
                    break;
                case Forty:
                    score = "Forty-All";
                    break;
                default:
                    score = "Deuce";
                    break;

            }
            return score;
        }
        /// <summary>
        /// so sánh 2 numscore lớn hơn 4(Num)
        /// num 1 - num 2 = 1: score = advantage playerNameOne
        /// num 1 - num 2 = -1: score = advantage playerNameTwo
        /// num 1 - num 2 >=2 : score = playerNameOne win
        /// else(num 1 - num 2 < 2) score = playerNameTwo win
        /// kêt quả trả về là 1 string(score)
        /// </summary>
        /// <param string name="playerNameOne"></param>
        /// <param string name="playerNameTwo"></param>
        /// <param int name="NumScoreOne"></param>
        /// <param int name="NumScoreTwo"></param>
        /// <returns></returns>
        private static string GetNumScoreEqualsNum(string playerNameOne, string playerNameTwo, int NumScoreOne, int NumScoreTwo)
        {
            string score = "";
            int minusResult = NumScoreOne - NumScoreTwo;
            if (minusResult == 1)
                    score = $"Advantage {playerNameOne}";
            else if (minusResult == -1)
                score = $"Advantage {playerNameTwo}";
            else if (minusResult >= 2) score = $"Win for {playerNameOne}";
            else score = $"Win for {playerNameTwo}";

            return score;
        }

        /// <summary>
        /// so sánh 2 numscore khác nhau và bé hơn 4
        /// trả về string(score)
        /// </summary>
        /// <param int name="NumScoreOne"></param>
        /// <param int name="NumScoreTwo"></param>
        /// <returns></returns>
        private static string GetNumScoreNoEquals(int NumScoreOne, int NumScoreTwo)
        {
            int tempScore = 0;
            string score = "";
            for (int i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = NumScoreOne;
                else { 
                    score += "-"; 
                    tempScore = NumScoreTwo; 
                }
                switch (tempScore)
                {
                    case Love:
                        score += "Love";
                        break;
                    case Fifteen:
                        score += "Fifteen";
                        break;
                    case Thirty:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }
            return score;
        }
        public static void GetScore(string playerNameOne, string playerNameTwo, int NumScoreOne, int NumScoreTwo)
        {

            if (NumScoreOne == NumScoreTwo)
            {
                Console.WriteLine(TennisGame.GetNumEquals(NumScoreOne));
            }
            else if (NumScoreOne >= Num || NumScoreTwo >= Num)
            {
                Console.WriteLine(TennisGame.GetNumScoreEqualsNum(playerNameOne, playerNameTwo, NumScoreOne, NumScoreTwo));
            }
            else
            {
                Console.WriteLine(TennisGame.GetNumScoreNoEquals(NumScoreOne, NumScoreTwo));
            }
        }
    }
}
