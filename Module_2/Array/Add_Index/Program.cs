using System;

namespace Add_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhập n:");
            n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            Console.WriteLine("Nhập X số muốn chèn: ");
            int X = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập index là vị trí muốn chèn");
            int index = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (index <= 1 && index >= (arr.Length - 1))
                {
                    Console.WriteLine("không chèn được phần tử vào mảng");
                }
                else
                {
                    if (i == index)
                    {
                        for (int j = arr.Length - 1; j > index; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        arr[index] = X;

                    }
                }
            }
            Console.WriteLine("Mảng sau khi chèn là: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
