using System;


namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_1 = 0, num_2 = 0;
            try
            {
                Console.Write("Enter a number: ");
                 num_1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter a number 2: ");
                 num_2 = Int32.Parse(Console.ReadLine());

                Console.WriteLine((float)num_1 / num_2);
            }
            //Tổng quát: 
            //catch(Exception e)
            //{
            //    Console.WriteLine($"{e.GetType()},{e.Message}");
            //}
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("sau khi khoi tao lai value");
                Console.WriteLine($"{num_1},{num_2}");
            }

            Console.ReadKey();
        }
    }
}
