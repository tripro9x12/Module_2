using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        public static List<string> myList = new List<string>();
        static void Main(string[] args)
        {
            myList.Add("lion");
            myList.Add("cat");
            myList.Add("dog");
            myList.Add("elephant");
            Show();
            DeleteDog();
            Console.WriteLine("remove dog:");
            Show();
            
            myList.Sort();
            Console.WriteLine("sort: ");
            Show();
            ShowIndexCat();
        }
        public static void Show()
        {
            foreach(var list in myList)
            {
                Console.WriteLine(list);
            }
        }
        public static void DeleteDog()
        {
            for(int i = 0; i<myList.Count;i++)
            {
                if(myList[i] == "dog")
                {
                    myList.Remove("dog");
                }
            }
        }
        public static void ShowIndexCat()
        {
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == "cat")
                {
                    Console.WriteLine($"index cat = {i}");
                }
            }
        }
    }
}
