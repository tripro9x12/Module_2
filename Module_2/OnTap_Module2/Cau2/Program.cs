using System;

namespace Cau2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter m:");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            int k = Int32.Parse(Console.ReadLine());

            Console.WriteLine("MaTrix 1");
            int[,] A = CreateMatrix(n, m);
            Console.WriteLine("MaTrix 2");
            int[,] B = CreateMatrix(m, k);

            int[,] array = MultipleMatrix(A, B, n, m, k);

            ShowMatrix(A);
            ShowMatrix(B);
            ShowMatrix(array);

        }
        static int[,] CreateMatrix(int row,int col)
        {
            int[,] array = new int[row, col];
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]");
                    array[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        static int[,] MultipleMatrix(int[,] A,int[,] B, int n,int m,int k)
        {
            int[,] array = new int[n, k];
            for(int i = 0; i < n;i++)
            {
                for(int j = 0; j < k; j++)
                {
                    int sum = 0;
                    for(int h = 0; h < m; h++)
                    {
                        sum += A[i, h] * B[h, j];
                    }
                    array[i, j] = sum;
                }
            }
            return array;
        }
        static void ShowMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------");
            
        }
    }
}
