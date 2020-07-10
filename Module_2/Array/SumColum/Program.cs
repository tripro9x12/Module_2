using System;

namespace SumColum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Enter row: ");
            int row = Int32.Parse(Console.ReadLine());
            Console.Write("Enter col: ");
            int col = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[row, col];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Nhập arr[{i},{j}]");
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("các phần tử của mảng");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.Write("Nhập cột muốn tính tổng:");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == n)
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.Write($"sum = {sum}");
        }
    }
}
