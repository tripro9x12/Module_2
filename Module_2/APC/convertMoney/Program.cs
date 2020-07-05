using System;

namespace convertMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            Console.WriteLine("Nhập số tiền USD muốn đổi: ");
            int USD = Int32.Parse(Console.ReadLine());
            int VND;
            VND = USD * rate;
            Console.Write("số tiền sau khi convert là: {0} ", VND);
        }
    }
}
