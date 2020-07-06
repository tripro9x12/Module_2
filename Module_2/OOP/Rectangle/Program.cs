using System;

namespace Rectangle {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("nhập height: ");
            int height = Int32.Parse (Console.ReadLine ());
            Console.WriteLine ("Nhập width: ");
            int width = Int32.Parse (Console.ReadLine ());

            Rectangle rectangle = new Rectangle (width, height);
            Console.WriteLine (rectangle.Display ());
            Console.WriteLine (rectangle.GetArea ());

            Console.ReadKey ();
        }
    }
}