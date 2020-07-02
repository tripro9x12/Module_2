using System;

namespace PT_Bac1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Nhập a:");
            double a = Double.Parse (Console.ReadLine ());
            Console.WriteLine ("Nhập b:");
            double b = Double.Parse (Console.ReadLine ());
            if (a == 0) {
                if (b == 0) {
                    Console.Write ("PT vô nghiệm");
                } else {
                    Console.Write ("PT vô số nghiệm");
                }
            } else {
                double x;
                x = -b / a;
                Console.Write ($"PT có nghiệm x = {x} ");
            }
        }
    }
}