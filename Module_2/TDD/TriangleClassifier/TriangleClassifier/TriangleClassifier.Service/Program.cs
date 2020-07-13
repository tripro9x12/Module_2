using System;

namespace TriangleClassifier.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle_1 = new Triangle(3, 3, 3);
            Console.WriteLine(triangle_1.ToString());

            Triangle triangle_2 = new Triangle(2,2,3);
            Console.WriteLine(triangle_2.ToString());

            Triangle triangle_3 = new Triangle();

            triangle_3.A = 3;
            triangle_3.B = 4;
            triangle_3.C = 5;
            Console.WriteLine(triangle_3.ToString());


        }
    }
}
