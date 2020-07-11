using System;
using System.Collections.Generic;
using System.Text;

namespace IColorable
{
    public abstract class Shape : Icolorabale
    {
        private string color = "green";
        private bool filled = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string getColor()
        {
            return color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public void setColor(string color)
        {
            this.color = color;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isFilled()
        {
            return filled;
        }
        public abstract double GetArea();

        public void setFilled(bool filled)
        {
            this.filled = filled;
        }

        public override string ToString()
        {
            return "A Shape with color of "
                    + getColor()
                    + " and "
                    + (isFilled() ? "filled" : "not filled");
        }

        public virtual void HowToColor() { }
        public virtual string Name() {
            return "";
        }

    }
}
