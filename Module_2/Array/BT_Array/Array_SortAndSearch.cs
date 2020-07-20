using System;
using System.Collections.Generic;
using System.Text;

namespace BT_Array
{
    class Array_SortAndSearch
    {
        public static Random random = new Random();
        public static void Main()
        {
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            bool check = false;

            string y = "y";
            while (y == "y")
            {
                Console.WriteLine("1.CreateArray");
                Console.WriteLine("2.Show");
                Console.WriteLine("3.IsSymmetryArray");
                Console.WriteLine("4.SortArray");
                Console.WriteLine("5.SearchIndex");
                Console.WriteLine("6.Exit");

                Console.Write("Moi ban chon: ");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateArray(ref arr);
                        break;
                    case 2:
                        Show(arr);
                        break;
                    case 3:
                        Console.WriteLine(IsSymmetryArray(arr));
                        break;
                    case 4:
                        SortArray(ref arr,ref check);
                        break;
                    case 5:
                        if (check)
                        {
                            Console.Write("Enter Search Number: ");
                            int number = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(SearchIndex(arr, 0, arr.Length - 1, number));
                        }
                        else
                        {
                            Console.WriteLine("Ban phai goi ham Sort truoc da:");
                        }
                        
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Nhap sai, moi ban nhap lai: ");
                        break;
                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("nhap y de tiep tuc, nhap bat ky de thoat...");
                y = Console.ReadLine();
            }

            Console.ReadKey();

        }
        public static void CreateArray(ref int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                //arr[i] = random.Next(30, 60);
                Console.Write($"arr[{i}]: ");
                arr[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public static void Show(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr[{i}]: {arr[i]}");
            }
        }
        public static bool IsSymmetryArray(int[] arr)
        {
            for(int i = 0; i < arr.Length / 2; i++)
            {
                if(arr[i] == arr[arr.Length -1 - i])
                {
                    return true;
                }
            }
            return false;
        }
        public static void SortArray(ref int[] arr,ref bool check)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            check = true;
        }
        public static string SearchIndex(int[] arr, int first,int last,int number)
        {
            if (last >= 0)
            {
                int mid = first + (last - first) / 2;
                if(arr[mid] == number)
                {
                    return $"index: {mid}";
                }
                if (arr[mid] > number)
                {
                    return SearchIndex(arr, first, mid - 1, number);
                }
                return SearchIndex(arr, mid + 1, last, number);
            }
            return $"Khong Tim Thay";
        }
    }
}
