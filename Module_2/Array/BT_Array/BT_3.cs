using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Array
{ 
    class BT_3
    {
        public static Random random = new Random();
        public static int[,] arr;
        public static void Main()
        {
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = Int32.Parse(Console.ReadLine());
            arr = new int[n, m];
            Input(ref arr);
            Show(arr);
            ShowDivideByAllFive(arr);
            NewArr(ref arr,m, n);
            Show(arr);

            Console.ReadLine();
        }
        public static void Input(ref int[,] arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(20, 60);
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
        public static void ShowDivideByAllFive(int[,] arr)
        {
            bool check = false;
            Console.WriteLine("All Number Divide By All Five: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] % 5 == 0)
                    {
                        check = true;
                        Console.WriteLine(arr[i, j]);
                    }                    
                }

            }
            if (!check)
            {
                Console.WriteLine("No Number");
            }
        }
        public static void NewArr(ref int[,] arr, int m,int n)
        {
            arr = new int[m, n];
            Console.WriteLine("New Arr: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(20, 60);
                }
            }
        }
    }
}
