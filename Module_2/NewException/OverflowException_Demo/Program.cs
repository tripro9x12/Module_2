using System;

namespace OverflowException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter num 1: ");
                int number_1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter num 2: ");
                int number_2 = Int32.Parse(Console.ReadLine());

                int multi = number_1 * number_2;
                Console.WriteLine(multi);
            }
            catch (OverflowException e)
            {

                Console.WriteLine($"{e.GetType().Name}, {e.Message}");
            }
        }
    }
}
