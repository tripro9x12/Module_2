using System;

namespace sumColEqualsRow
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


            int sum = 0;
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                int sum_1 = 0, sum_2 = 0;
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j == i)
                        {
                            sum_1 += arr[i, j];
                        }
                    }

                }
                Console.WriteLine($"sum đường chéo 1 = {sum_1}");
                for (int i = arr.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = arr.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (j == i)
                        {
                            sum_2 += arr[i, j];
                        }
                    }
                }
                Console.WriteLine($"sum đường chéo 2 = {sum_2}");
                sum = sum_1 + sum_2;

            }
            else
            {
                Console.WriteLine("Không phải là ma trận vuông");
            }

            Console.Write($"sum = {sum}");
        }
    }
}
