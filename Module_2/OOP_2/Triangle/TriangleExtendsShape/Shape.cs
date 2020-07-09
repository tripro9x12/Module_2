using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleExtendsShape
{
    public class Shape
    {
        public double side1 = 1.0;
        public double side2 = 1.0;
        public double side3 = 1.0;
        public Shape() { }
        public Shape(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double GetArea()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.side1) * (p - this.side2) * (p - this.side3));
        }
        public double GetPerimeter()
        {
            return this.side1 + this.side2 + this.side3;
        }
        public override string ToString()
        {
            return $"area = {this.GetArea()}, perimater = {this.GetPerimeter()}";
        }
    }
}
