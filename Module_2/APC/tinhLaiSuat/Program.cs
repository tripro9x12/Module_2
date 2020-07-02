using System;

namespace tinhLaiSuat
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int month;
            double intersetRate;

            Console.WriteLine("Nhập số tiền: ");
            money = Double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số tháng gửi: ");
            month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Nhập % lãi suất: ");
            intersetRate = Double.Parse(Console.ReadLine());

            double totalInterset = 0;
            for (int i = 0; i < month; i++)
            {
                totalInterset = money * (intersetRate / 100) / 12 * 3;
            }
            Console.WriteLine("Total of interset: " + totalInterset);

        }
    }
}
