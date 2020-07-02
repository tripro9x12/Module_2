using System;

namespace Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            dynamic c2 = new MyClass();
            Console.WriteLine(c1.ReturnMassage());
            Console.WriteLine($"Hello World! {c2.ReturnMassage()}");

            // số nguyên tố
            Console.WriteLine("Nhập giá trị của number");
            int number = Convert.ToInt32(Console.ReadLine());
            var check_SNT = new soNguyenTo();
            Console.WriteLine($"{check_SNT.checkSoNguyenTo(number)}");
        }
    }
}