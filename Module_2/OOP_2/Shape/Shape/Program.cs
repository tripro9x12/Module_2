using System;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle);

            circle = new Circle(3.5);
            Console.WriteLine(circle);

            circle = new Circle(3.5, "indigo", false);
            Console.WriteLine(circle);


            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);

            rectangle = new Rectangle(2.5, 3.8, "orange", true);
            Console.WriteLine(rectangle);

        }
    }
}
