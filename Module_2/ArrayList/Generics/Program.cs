using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> generic_1 = new Generic<int>();
            Console.WriteLine(generic_1.Equal(3, 4));
            Console.WriteLine(generic_1.Equal(4, 4));

            Generic<string> generic_2 = new Generic<string>();
            Console.WriteLine(generic_2.Equal("dog", "dog"));
            Console.WriteLine(generic_2.Equal("cat", "dog"));
        }
    }
}
