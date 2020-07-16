using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class HashtableDemo
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, new Student()
            {
                StudentId = 1,
                StudentName = "Tung"
            });

            hashtable.Add(2, new Student()
            {
                StudentId = 2,
                StudentName = "Tri"
            });

            hashtable.Add(3, new Student()
            {
                StudentId = 3,
                StudentName = "My"
            });

            foreach(var value in hashtable.Values)
            {
                Console.WriteLine(value.ToString());
            }
        }
    }
}
