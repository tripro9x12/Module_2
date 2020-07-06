using System;
namespace QuadraticEquation {
    public class QuadraticEquation {
        private double a;
        private double b;
        private double c;
        double delta;
        public QuadraticEquation (double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetterA () => this.a;
        public double GetterB () => this.b;
        public double GetterC () => this.c;
        public double GetDiscriminant () => delta = this.b * 2 - 4 * this.a * this.c;
        public void GetRoot () {
            double x, x1, x2;
            if (this.GetDiscriminant () < 0) {
                Console.WriteLine ("The equation has no roots");
            } else if (this.GetDiscriminant () == 0) {
                x = -this.b / (2 * this.a);
                Console.WriteLine ($"PT có Ng kép: {x}");
            } else {
                x1 = (-this.b + Math.Pow (this.GetDiscriminant (), 0.5)) / (2 * this.a);
                x2 = (-this.b - Math.Pow (this.GetDiscriminant (), 0.5)) / (2 * this.a);
                Console.WriteLine ($"PT có 2 Ng: x1 ={x1}, x2 = {x2}");
            }
        }

    }
}