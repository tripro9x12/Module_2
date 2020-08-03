using System;

namespace Cau01
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            int[] array = new int[0];
            bool check = false;

            int choice = 1;
            while (choice != 6)
            {
                Console.WriteLine("1.CreateArray");
                Console.WriteLine("2.IsSymmetryArray");
                Console.WriteLine("3.SelectionSort");
                Console.WriteLine("4.Show");
                Console.WriteLine("5.Find");
                Console.WriteLine("6.Exit");

                Console.WriteLine("-------------------------------------------------");
                Console.Write("Moi ban lua chon.......");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateArray(ref array);
                        break;
                    case 2:
                        Console.WriteLine(IsSymmetryArray(array));
                        break;
                    case 3:
                        SelectionSort(ref array, ref check);
                        break;
                    case 4:
                        Show(array);
                        break;
                    case 5:
                        if (check)
                        {
                            Console.Write("Enter Number Search: ");
                            int number = Int32.Parse(Console.ReadLine());
                            string result = Find(array, 0, array.Length - 1, number) != -1 ? $"index = {Find(array, 0, array.Length - 1, number)}" : "Khong tim thay";
                            Console.WriteLine("------>>>" + result);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai goi ham SelectionSort truoc da....");
                        }
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Lua chon cua ban khong hop le....");
                        break;
                }
            }

        }
        static void CreateArray(ref int[] array)
        {
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                //Console.Write($"arr[{i}] = ");
                //array[i] = Int32.Parse(Console.ReadLine());
                array[i] = random.Next(30, 60);
            }
        }
        static bool IsSymmetryArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void SelectionSort(ref int[] array, ref bool check)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            check = true;
        }
        static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }
        static int Find(int[] array, int f, int l, int number)
        {
            if (l >= 0)
            {
                int mid = f + (l - f) / 2;
                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] > number)
                {
                    return Find(array, f, mid - 1, number);
                }
                else
                {
                    return Find(array, mid + 1, l, number);
                }
            }
            return -1;
        }
    }
}
