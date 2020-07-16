using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class ArrayListDemo
    {
        public static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Student()
            {
                StudentId = 1,
                StudentName = "Long"
            });
            arrayList.Add(new Student()
            {
                StudentId = 2,
                StudentName = "Vui"
            });
            arrayList.Add(new Student()
            {
                StudentId = 3,
                StudentName = "Buồn"
            });
            Console.WriteLine($"StudentId\tStudentName");
            foreach(Student student in arrayList)
            {
                Console.WriteLine(student.ToString());
            }

        }
    }
}
