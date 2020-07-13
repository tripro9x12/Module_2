using System;

namespace NextDayCalculator.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            NextDay nextday = new NextDay();
            int day = 3;
            int month = 1;
            int year =   1998;
            Console.WriteLine(nextday.GetDateTime( day, month,  year));
            Console.WriteLine(nextday.GetDateTime(29, 2, 2000));
            Console.WriteLine(nextday.GetDateTime(31, 12, 2000));

        }
    }
}
