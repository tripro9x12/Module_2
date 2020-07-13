using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleClassifier.Service
{
    public class Triangle
    {
        private int a { get; set; }
        private int b { get; set; }
        private int c { get; set; }
        public Triangle()
        {

        }
        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public int A
        {
            get => this.a;
            set => this.a = value;
        }
        public int B
        {
            get => this.b;
            set => this.b = value;
        }
        public int C
        {
            get => this.c;
            set => this.c = value;
        }
        public string GetTriangle(int a, int b, int c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                {
                    return "tam giác vuông";
                }else if(a == b && a == c)
                {
                    return "tam giác đều";
                }else if(a == b || a == c || b == c)
                {
                    return "tam giác cân";
                }
                else
                {
                    return "tam giác thường";
                }

            }
            else
            {
                return "không phải là tam giác";
            }
        }

        public override string ToString()
        {
            return $"a = {this.a}, b = {this.b}, c= {this.c}";
        }

    }
}
