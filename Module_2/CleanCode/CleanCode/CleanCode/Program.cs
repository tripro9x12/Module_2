using System;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Refactoring.Calculate(3, 4, '+'));

            Console.WriteLine(Refactoring.FizzBuzz(15));


            Console.Write("Nhập radius: ");
            int radius = Int32.Parse(Console.ReadLine());
            Console.Write("Nhập height: ");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"GetPerimeter: {CylinderDemo.GetVolume(radius,height)}");

            Console.ReadKey();
        }
    }
}
