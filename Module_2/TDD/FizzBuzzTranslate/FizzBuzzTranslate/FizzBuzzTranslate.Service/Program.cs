using System;

namespace FizzBuzzTranslate.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
            Console.WriteLine(fizzbuzz.CountTraslate(26));
        }
    }
}
