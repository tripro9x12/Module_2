using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3,"red");
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"diện tích: {circle.GetDienTich()}");

            Cylinder cylinder = new Cylinder(3,3,"yellow");
            Console.WriteLine(cylinder.ToString());

            Console.ReadKey();
        }
    }
}
