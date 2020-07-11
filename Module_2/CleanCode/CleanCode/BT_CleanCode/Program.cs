using System;

namespace BT_CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisGame.GetScore("Tri","Thanh",1,1);
            TennisGame.GetScore("Tri", "Thanh", 6, 4);
            TennisGame.GetScore("Tri", "Thanh", 0, 1);
            Console.ReadKey();
        }
    }
}
