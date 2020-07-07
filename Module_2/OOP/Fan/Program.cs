using System;

namespace Fan {
    class Program {
        static void Main (string[] args) {
            Fan fan_1 = new Fan ();
            Console.WriteLine ("Nhập speed 1: ");
            int speed_1 = Int32.Parse (Console.ReadLine ());
            fan_1.ON = true;
            fan_1.setSpeed (speed_1);
            fan_1.RADIUS = 10;
            fan_1.COLOR = "Yellow";
            Console.WriteLine (fan_1.toString_s ());

            Fan fan_2 = new Fan ();
            Console.WriteLine ("Nhập speed 2: ");
            int speed_2 = Int32.Parse (Console.ReadLine ());
            fan_2.ON = false;
            fan_2.setSpeed (speed_2);
            fan_2.COLOR = "";
            Console.WriteLine (fan_2.toString_s ());

            Console.ReadKey ();
        }
    }
}