using System;

namespace FormatException_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //float price = 169.32f;
                //Console.WriteLine("The cost is {0}.", price);
                decimal price = 169.32m;
                Console.WriteLine("The cost is {0:Q2}.", price);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
