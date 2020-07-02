using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;

            Console.Write("Nhập chiều rộng: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Nhập chiều dài: ");
            height = float.Parse(Console.ReadLine());

            float area = width * height;
            Console.WriteLine("diện tích là:: " + area);

        }
    }
}
