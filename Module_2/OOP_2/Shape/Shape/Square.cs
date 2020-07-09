using System;
using System.Collections.Generic;
using System.Text;
namespace Shape
{

        public class Square : Rectangle
        {
            public Square()
            {
            }

            public Square(double side) : base(side, side)
            {
            }

            public Square(double side, string color, bool filled) : base(side, side, color, filled)
            {
            }

            public double getSide()
            {
            return GetWidth();
            }

            public void setSide(double side)
            {
                base.SetWidth(side);
                base.SetLength(side);
            }
            public override void SetWidth(double width)
            {
                setSide(width);
            }

            public override void SetLength(double length)
            {
                setSide(length);
            }

            public override string ToString()
            {
                return "A Square with side="
                        + getSide()
                        + ", which is a subclass of "
                        + base.ToString();
            }
        }
}
