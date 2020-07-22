using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace InvalidOperationException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            person.Add(new Person()
            {
                Name = "An",
                Age = 27,
                Gender = "Male"
            });
            person.Add(new Person()
            {
                Name = "My",
                Age = 25,
                Gender = "Male"
            });
            person.Add(new Person()
            {
                Name = "Hoa",
                Age = 21,
                Gender = "Female"
            });

            
            try
            {
                person.Sort(new SortPersonName<Person>());
                foreach (Person item in person)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.GetType().Name}, {e.Message}");
            }

            try
            {
                int count = person.Count;
                for (int i = 0; i < count; i++)
                {
                    person.Remove(person[0]);
                }
                
               
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.GetType().Name}, {e.Message}");
            }
            finally
            {
                Console.WriteLine($"Count = {person.Count}");
            }
        }

        public class SortPerson : IComparer
        {
            public int Compare(object x, object y)
            {
                return string.Compare(((Person)x).Name, ((Person)y).Name);
            }
        }
        public class SortPersonAge<T> : IComparer<Person>
        {
            public int Compare([AllowNull] Person x, [AllowNull] Person y)
            {
                if (x.Age > y.Age)
                {
                    return 1;
                }
                else if (x.Age == y.Age)
                {
                    return 0;
                }
                else return 0;
            }
        }
        public class SortPersonName<T> : IComparer<Person>
        {
            public int Compare([AllowNull] Person x, [AllowNull] Person y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
    }
    
    

}
