using System;
namespace Student
{
    public class Students
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";

        //constructor to initialize the variable
        public Students(int r, string n)
        {
            this.rollno = r;
            this.name = n;
        }


        public static void Change()
        {
            college = "CODEGYM";
        }

        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}