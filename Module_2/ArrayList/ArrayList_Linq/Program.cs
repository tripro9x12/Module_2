using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList_Linq
{
    class Program
    {
        public static ArrayList arrayList = new ArrayList();
        static void Main(string[] args)
        {
            arrayList.Add(new Staff()
            {
                Id = 1,
                Name = "Nam",
                Age = 24
            });
            arrayList.Add(new Staff()
            {
                Id = 2,
                Name = "Kien",
                Age = 21
            });
            arrayList.Add(new Staff()
            {
                Id = 3,
                Name = "Viet",
                Age = 21
            });
            arrayList.Add(new Staff()
            {
                Id = 4,
                Name = "Hang",
                Age = 23
            });
            arrayList.Add(new Staff()
            {
                Id = 5,
                Name = "Tien",
                Age = 24
            });
            Show();
            Console.WriteLine("sort by Name");
            ShowLinq();
        }
        public static void Show()
        {
            foreach(Staff item in arrayList)
            {
                Console.WriteLine($"{item.Id} | {item.Name} | {item.Age}");
            }
        }
        public static void ShowLinq()
        {
            //var rs = arrayList.Where(e => e.Age);
            var result = (from Staff s in arrayList where s.Age < 24 orderby s.Name select s);
            foreach (Staff staff in result)
            {
                Console.WriteLine($"{staff.Id} | {staff.Name} | {staff.Age}");
            }
        }
    }
}
