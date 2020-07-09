using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    public class Point3D : Point2D
    {
        new public float[] arr = new float[3];
        public float z = 0.0f;
        public Point3D() { }
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float Z
        {
            get => this.z;
            set => this.z = value;
        }
        public void setXZY(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float[] getXYZ()
        {
            arr[0] = this.x;
            arr[1] = this.y;
            arr[2] = this.z;
            return arr;
        }
        public override string ToString()
        {
            return $" {base.ToString()},z = {this.z}";
        }
    }
}
