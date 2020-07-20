using System;

namespace BT_Array
{
    class BT_1
    {
        public static Random random = new Random();
        public static void Main()
        {    
            Console.Write("Enter n of length Arr: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            InputArr(ref arr);
            ShowArr(arr);
            SumEven(arr);
            SumDiagonalMain(arr);
            SumDiagonalFiller(arr);
            ShowTriangleDown(arr);
            ShowTriangleUp(arr);
            Console.ReadKey();
        }
        public static void InputArr(ref int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(10, 90);
                }
            }
        }
        public static void ShowArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }

        public static void SumEven(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
                
            }
            Console.WriteLine($"SumEven: {sum}");
        }
        public static void SumDiagonalMain(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += arr[i, j];
                    }
                }
                
            }
            Console.WriteLine($"SumDiagonalMain: {sum}");
        }
        public static void SumDiagonalFiller(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1)-1; j>=0; j--)
                {
                    if (j==arr.GetLength(1)-1-i)
                    {
                        sum += arr[i, j];
                    }
                }

            }
            Console.WriteLine($"SumDiagonalFiller: {sum}");
        } 

        public static void ShowTriangleDown(int[,] arr)
        {
            Console.WriteLine("------------------------");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <=i; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
        public static void ShowTriangleUp(int[,] arr)
        {
            Console.WriteLine("------------------------");
            for (int i = 0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j<arr.GetLength(1)-i; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
