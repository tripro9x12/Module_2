using System;

namespace showHello {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Nhập tên người cần chào: ");
            string name = Console.ReadLine ();
            Console.WriteLine ($"Hello {name} ");
        }
    }
}