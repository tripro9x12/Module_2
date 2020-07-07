using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Students.Change();
            Students s1 = new Students(111, "Hoang");
            Students s2 = new Students(222, "Khanh");
            Students s3 = new Students(333, "Nam");


            s1.Display();
            s2.Display();
            s3.Display();
        }
    }
}
