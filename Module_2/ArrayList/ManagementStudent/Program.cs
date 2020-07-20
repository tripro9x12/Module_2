using System;
using System.Collections;
using System.Collections.Generic;

namespace ManagementStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList student = new ArrayList();
            student.Add(new Student()
            {
                Name = "Tri",
                Age = 23
            });
            student.Add(new Student()
            {
                Name = "An",
                Age = 27
            });
            student.Add(new Student()
            {
                Name = "My",
                Age = 25
            });

            foreach(Student item in student)
            {
                Console.WriteLine($"{item.Name} | {item.Age}");
            }

            student[0] = new Student()
            {
                Name = "Nhan",
                Age = 29
            };

            foreach (Student item in student)
            {
                Console.WriteLine($"{item.Name} | {item.Age}");
            }

            student.RemoveAt(2);

            foreach (Student item in student)
            {
                Console.WriteLine($"{item.Name} | {item.Age}");
            }
        }
    }
}
