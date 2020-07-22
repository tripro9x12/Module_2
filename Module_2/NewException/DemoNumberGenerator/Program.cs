using System;

namespace DemoNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var gen = new NumberGenerator();
            int index = 10;
            try
            {
                int value = gen.GetNumber(index);
                Console.WriteLine($"value = {value}");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.GetType().Name} : {index} : {e.Message}");
            }
        }
    }
    public class NumberGenerator
    {
        int[] number = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        public int GetNumber(int index)
        {
            if(index<0 || index >= number.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return number[index];
            }
        }
    }
}
