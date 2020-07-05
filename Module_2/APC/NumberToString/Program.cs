using System;

namespace NumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số cần đọc: ");
            int num = Int32.Parse(Console.ReadLine());

            if (num >= 0 && num < 1000)
            {
                if (num >= 0 && num < 10)
                {
                    motChuSo(num);
                }
                if (num >= 10 && num < 100)
                {
                    haiChuSo(num);
                }
                else
                {
                    int a = num / 100;
                    baChuSo(a);
                    int b = num % 100;
                    haiChuSo(b);

                }
            }
        }
        static void baChuSo(int num)
        {
            switch (num)
            {
                case 1:
                    Console.Write("one hundred and ");
                    break;
                case 2:
                    Console.Write("two hundred and ");
                    break;
                case 3:
                    Console.Write("three hundred end ");
                    break;
                case 4:
                    Console.Write("four hundred end ");
                    break;
                case 5:
                    Console.Write("five hundred end ");
                    break;
                case 6:
                    Console.Write("six hundred end ");
                    break;
                case 7:
                    Console.Write("seven hundred end ");
                    break;
                case 8:
                    Console.Write("eight hundred end ");
                    break;
                case 9:
                    Console.Write("nine hundred end ");
                    break;
            }
        }
        static void haiChuSo(int num)
        {
            if (num >= 0 && num < 20)
            {
                switch (num)
                {
                    case 10:
                        Console.Write("ten");
                        break;
                    case 11:
                        Console.Write("eleven");
                        break;
                    case 12:
                        Console.Write("twelve");
                        break;
                    case 13:
                        Console.Write("thirteen");
                        break;
                    case 14:
                        Console.Write("fourteen");
                        break;
                    case 15:
                        Console.Write("fifteen");
                        break;
                    case 16:
                        Console.Write("sixteen");
                        break;
                    case 17:
                        Console.Write("seventeen");
                        break;
                    case 18:
                        Console.Write("eightteen");
                        break;
                    case 19:
                        Console.Write("nineteen");
                        break;
                }
            }
            if (num >= 20 && num < 100)
            {
                int num_a = num / 10;
                switch (num_a)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eightty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }
                int num_b = num % 10;
                switch (num_b)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }

            }
        }
        static void motChuSo(int num)
        {
            switch (num)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }

        }

    }
}