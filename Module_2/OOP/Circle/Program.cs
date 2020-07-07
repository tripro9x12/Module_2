using System;

namespace Circle {
    class Program {
        static void Main (string[] args) {
            Circle circle = new Circle ();
            circle.Radius = 2;
            circle.Color = "Blue";
            circle.Show ();

            Circle circle_2 = new Circle ();
            circle_2.Show ();

            Circle circle_3 = new Circle (3, "Black");
            circle_3.Show ();
        }
    }
}