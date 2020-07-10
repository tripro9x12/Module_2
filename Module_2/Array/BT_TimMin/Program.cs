using System;

namespace BT_TimMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng phần tử của arr: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            int min = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            Console.WriteLine($"index = {index}, min = {min}");
        }
    }
}
