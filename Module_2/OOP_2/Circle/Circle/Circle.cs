using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Circle
{
    public class Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }
        public Circle()
        {

        }

        public Circle(double Radius, string Color)
        {
            this.Radius = Radius;
            this.Color = Color;
        }
        public double GetRadius() => this.Radius;
        public string GetColor() => this.Color;

        public double GetDienTich()
        {
            return this.Radius * Math.PI;
        }
        public override string ToString()
        {
            return $"radius: {this.GetRadius()}, color: {this.GetColor()}";
        }

    }
}
