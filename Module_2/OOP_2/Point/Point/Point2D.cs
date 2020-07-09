using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    public class Point2D
    {
        public float[] arr = new float[2];
        public float x = 0.0f;
        public float y = 0.0f;
        public Point2D() { }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(float x)
        {
            this.x = x;
        }
        public float getX() => this.x;

        public void setY(float y)
        {
            this.y = y;
        }
        public float getY() => this.y;

       public void setXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] getXY()
        {
            arr[0] = this.x;
            arr[1] = this.y;
            return this.arr;
        }
        public override string ToString()
        {
            return $"x = {this.x}, y = {this.y}";
        }


    }
}
