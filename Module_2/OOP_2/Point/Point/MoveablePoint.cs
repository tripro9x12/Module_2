using System;
using System.Collections.Generic;
using System.Text;

namespace Point
{
    public class MoveablePoint : Point2D
    {
        public float xSpeed = 0.0f;
        public float ySpeed = 0.0f;
        public MoveablePoint() { }
        public MoveablePoint(float xSpeed, float ySpeed, float x, float y ) : base(x,y)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public float XSpeed
        {
            get => this.xSpeed;
            set => this.xSpeed = value;
        }
        public float YSpeed
        {
            get => this.ySpeed;
            set => this.ySpeed = value;
        }

        public float[] GetSpeed()
        {
            arr[0] = this.x;
            arr[1] = this.y;
            return arr;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public MoveablePoint Move()
        {
            this.x += xSpeed;
            this.y += ySpeed;
            //a = this.x;
            //b = this.y;
            return this;

        }

    }
}
