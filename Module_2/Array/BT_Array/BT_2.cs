using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Array
{
    public class BT_2
    {
        public static Random random = new Random();
        public static void Main()
        {
            Console.WriteLine("Enter n of length Arr: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            Input(ref arr);
            Show(arr);
            Sum(arr);
            Multi(arr);
        }
        public static void Input(ref int[,] arr)
        {
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 40);
                }
            }
        }
        public static void Show(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Sum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine($"Sum = {sum}");
        }
        public static void Multi(int[,] arr)
        {
            long multi = 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    multi *= arr[i, j];
                    
                }
            }
            Console.WriteLine($"Multi = {multi}");
        }
    }
}
