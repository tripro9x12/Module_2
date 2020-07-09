using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class CircleComparer : IComparer<Circle>
    {
        public int Compare(Circle c1, Circle c2)
        {
            if (c1.GetRadius() > c2.GetRadius()) return 1;
            else if (c1.GetRadius() < c2.GetRadius()) return -1;
            else return 0;
        }

    }
}
