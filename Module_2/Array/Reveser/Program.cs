using System;

namespace Reveser
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("Size does not exceed 20");
                }
            } while (size > 20);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            OutPut(size, array);
            Swap(size, array);
            Console.Write("Reveser ");
            OutPut(size, array);
        }

        static void OutPut(int size, int[] array)
        {
            Console.WriteLine("Elements in array: ", "");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
        }
        static void Swap(int size, int[] array)
        {
            for (int j = 0; j < array.Length / 2; j++)
            {
                int temp = array[j];
                array[j] = array[size - 1 - j];
                array[size - 1 - j] = temp;
            }
        }

    }
}
