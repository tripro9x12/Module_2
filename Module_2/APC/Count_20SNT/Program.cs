using System;

namespace Count_20SNT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập SNT cần log ra: ");
            int number = Int32.Parse(Console.ReadLine());
            int count = 0;
            int n = 0;
            while (count != number)
            {
                if (checkSNT(n) == true)
                {
                    Console.WriteLine($"Lần {count}: {n} ");
                    count++;
                }
                n++;
            }
        }
        static bool checkSNT(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else if (num == 2)
            {
                return true;
            }
            else
            {
                int dem = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        dem++;
                    }
                }
                if (dem == 2)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
