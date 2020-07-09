using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }
        public Cylinder() {
        }
        public Cylinder(double Height, double Radius, string Color) : base(Radius, Color)
        {
            this.Height = Height;
        }
        public double GetHeight() => this.Height;
        public double GetDienTichCylinder()
        {
            return 3.3;
        }
        public override string ToString()
        {
            return $"height: {this.GetHeight()}, {base.ToString()}";
        }
    }
}
