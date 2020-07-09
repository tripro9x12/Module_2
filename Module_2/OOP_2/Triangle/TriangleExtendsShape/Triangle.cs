using System;
using System.Collections.Generic;
using System.Text;


namespace TriangleExtendsShape
{
    public class Triangle : Shape
    {
        public string color { get; set; }
        public Triangle() { }
        public Triangle(double side1, double side2, double side3, string color) : base(side1, side2, side3)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"color = {this.color}, {base.ToString()}";
        }
    }
}
