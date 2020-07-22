using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class TupleDemo
    {
        public static void Main()
        {
            var MyTuple_1 = Tuple.Create<int, string>(1,"HowKtem");
            var MyTuple_2 = new Tuple<int, string, bool>(1, "Ktem", true);
  
            Console.WriteLine($"id = {MyTuple_2.Item1}, name = {MyTuple_2.Item2}, bool = {MyTuple_2.Item3}");

            var date = GetCurrentDayMonthYear();
            Console.WriteLine(date.ToString()); //c1
            Console.WriteLine($"Day = {date.Item1}, Month = {date.Item2},Year = {date.Item3}"); //c2

            Console.ReadKey();
        }
        public static Tuple<int,int,int> GetCurrentDayMonthYear()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
        }
    }
}
