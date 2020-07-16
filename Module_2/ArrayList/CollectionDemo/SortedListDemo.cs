using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CollectionDemo
{
    public class SortedListDemo
    {
        public static void Main()
        {
            SortedList sorted = new SortedList();
            sorted.Add(1, new Student()
            {
                StudentId = 1,
                StudentName = "Tan"
            }); 

            sorted.Add(2, new Student()
            {
                StudentId = 2,
                StudentName = "Son"
            });

            sorted.Add(3, new Student()
            {
                StudentId = 3,
                StudentName = "Tung"
            });

            foreach(var key in sorted.Keys)
            {
                Console.WriteLine(sorted[key].ToString());
            }

            //sorted.RemoveAt(1);
            sorted.Remove(2);
            foreach (var key in sorted.Keys)
            {
                Console.WriteLine(sorted[key].ToString());
            }
        }
    }
}
