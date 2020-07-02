using System;

namespace check_namnhuan {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Input Year");
            int year = Int32.Parse (Console.ReadLine ());
            bool isLeapYear = true;
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
                isLeapYear = true;
            } else {
                isLeapYear = false;
            }
            if (isLeapYear) {
                Console.WriteLine ($"{year} là năm nhuận");
            } else {
                Console.WriteLine ($"{year} không phải năm nhuận");
            }
        }
    }
}