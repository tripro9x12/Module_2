using System;

namespace CountDayOfMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập tháng: ");
            int month = Int32.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Tháng {month} có 31 ngày");
                    break;
                case 2:
                    Console.WriteLine($"Tháng {month} có 28 ngày or 29 ngày nếu năm nhuận");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Tháng {month} có 30 ngày");
                    break;
                default:
                    Console.WriteLine($"Nhập sai mời nhập lại: Tháng bạn vừa nhập là: {month}");
                    break;
            }
        }
    }
}
