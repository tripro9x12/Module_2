using System;

namespace TriangleExtendsShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Side1: ");
            double side1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Side2: ");
            double side2 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Side3: ");
            double side3 = Double.Parse(Console.ReadLine());
            Console.Write("Enter Color: ");
            string color = Console.ReadLine();

            Triangle triangle = new Triangle(side1,side2,side3,color);

            Console.WriteLine(triangle.ToString());

            Console.ReadKey();
        }
    }
}
