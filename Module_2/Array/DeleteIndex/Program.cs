using System;

namespace DeleteIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhập n: ");
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Nhập phần tử X muốn xóa: ");
            int X = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == X)
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            Array.Resize(ref arr, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
