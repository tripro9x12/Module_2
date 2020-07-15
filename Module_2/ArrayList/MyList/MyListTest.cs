using System;

namespace MyList
{
    class MyListTest
    {
        static void Main()
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(10);
            myList.Add(15);
            myList.Add(20);
            myList.Add(30);
            myList.Add(50);

            Console.WriteLine($"Item 1: {myList.GetDaTa(1)}");
            Console.WriteLine($"Item 4: {myList.GetDaTa(4)}");
            Console.WriteLine($"Item 2: {myList.GetDaTa(2)}");




            Console.ReadKey();

        }
    }
}
