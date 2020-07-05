using System;

namespace show_All_Hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Print the rectangle");
            Console.WriteLine("2.Print the square triangle (The corner is square at 4 different angles: top-left, top-right, botton-left, botton-right)");
            Console.WriteLine("3.Print isosceles triangle");
            Console.WriteLine("4.Exit");

            Console.WriteLine("nhập lựa chọn của bạn: ");
            int luachon = Int32.Parse(Console.ReadLine());
            switch (luachon)
            {
                case 1:
                    {
                        Console.WriteLine("Nhập n: ");
                        int n = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập m: ");
                        int m = Int32.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write(" * ");
                            }
                            Console.WriteLine("\n");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Mời bạn lựa chọn góc vuông ");
                        Console.WriteLine("1.top-left");
                        Console.WriteLine("2.top-right");
                        Console.WriteLine("3.bottom-left");
                        Console.WriteLine("4.bottom-right");
                        Console.WriteLine("5.Exit");

                        Console.WriteLine("nhập lựa chọn của bạn: ");
                        int luachon_tamgiac = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập chiều cao tam giác: ");
                        int h = Int32.Parse(Console.ReadLine());
                        switch (luachon_tamgiac)
                        {

                            case 1:
                                {
                                    for (int i = h; i >= 1; i--)
                                    {
                                        for (int j = 1; j <= i; j++)
                                        {
                                            Console.Write(" * ");
                                        }
                                        Console.WriteLine("\n");
                                    }

                                    break;
                                }
                            case 2:
                                {
                                    for (int i = h; i >= 1; i--)
                                    {
                                        for (int j = 1; j <= h; j++)
                                        {
                                            if (j <= (h - i))
                                            {
                                                Console.Write("   ");
                                            }
                                            else
                                            {
                                                Console.Write(" * ");
                                            }
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    break;
                                }
                            case 3:
                                {
                                    for (int i = 1; i <= h; i++)
                                    {
                                        for (int j = 1; j <= i; j++)
                                        {
                                            Console.Write(" * ");
                                        }
                                        Console.WriteLine("\n");

                                    }
                                    break;

                                }
                            case 4:
                                {
                                    for (int i = 1; i <= h; i++)
                                    {
                                        for (int j = 1; j <= h; j++)
                                        {
                                            if (j <= h - i)
                                            {
                                                Console.Write("   ");
                                            }
                                            else
                                            {
                                                Console.Write(" * ");
                                            }
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    break;
                                }
                            default: break;

                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Nhập chiều cao tam giác: ");
                        int h = Int32.Parse(Console.ReadLine());
                        for (int i = 1; i <= h; i++)
                        {
                            for (int j = 1; j < 2 * h; j++)
                            {
                                if (Math.Abs(h - j) < i)
                                {
                                    Console.Write(" * ");
                                }
                                else
                                {
                                    Console.Write("   ");
                                }
                            }
                            Console.WriteLine("\n");
                        }
                        break;
                    }
                case 4:
                default:
                    break;
            }
        }
    }
}
