using System;
using System.Collections.Generic;

namespace IndexOutOfRangeException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<char> myList = new List<char>();
                myList.InsertRange(0, new char[] { 'a', 'b', 'c','d','e','f' });
                int value = myList[6];
                Console.WriteLine(value);
            }
            catch(Exception e) //IndexOutOfRangeException không thực thi được;
            {
                Console.WriteLine(e.GetType().Name);
            }

        }
    }
}
