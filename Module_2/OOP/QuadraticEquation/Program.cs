using System;

namespace QuadraticEquation {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Nhập a: ");
            int a = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Nhập b: ");
            int b = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Nhập c: ");
            int c = Int32.Parse (Console.ReadLine ());

            QuadraticEquation ptbac2 = new QuadraticEquation (a, b, c);

            Console.WriteLine ($"a = {ptbac2.GetterA ()}");
            Console.WriteLine ($"b = {ptbac2.GetterB ()}");
            Console.WriteLine ($"c = {ptbac2.GetterC ()}");

            Console.WriteLine (ptbac2.GetDiscriminant ());
            ptbac2.GetRoot ();
        }
    }
}