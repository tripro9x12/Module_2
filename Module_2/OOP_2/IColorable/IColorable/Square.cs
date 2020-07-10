using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IColorable
{
    public class Square : Shape, Icolorabale
    {
        public double Width { get; set; }
        public Square()
        {
        }

        public Square(double width)
        {
            this.Width = width;
        }

        public Square(double width, string color, bool filled) : base(color, filled)
        {
            this.Width = width;
        }

        public double getWidth()
        {
            return this.Width;
        }

        
        public override double GetArea()
        {
            return this.Width * this.Width;
        }

        public override string ToString()
        {
            return "A Square with width ="
                    + getWidth()
                    + ", which is a subclass of "
                    + base.ToString();
        }

        public override void HowToColor()
        {
            Console.WriteLine("Color all four sides");
        }
    }
}
