using System;
using System.Collections.Generic;
using System.Text;

namespace Resizeable
{
    public interface Resizeable
    {
        public void Resize(double parcent);
        public double Size(double parcent);
    }


    public class Circle : Resizeable
    {
        public void Resize(double parcent)
        {
            parcent = parcent * new Random().Next(1, 100);
            Console.WriteLine($"kích thước Circle tăng lên: {parcent}");
        }
        public double Size(double parcent)
        {
            return parcent;
        }
    }
    public class Rectangle : Resizeable
    {
        public void Resize(double parcent)
        {
            parcent = parcent * new Random().Next(1, 100);
            Console.WriteLine($"kích thước Rectangle tăng lên: {parcent}");
        }
        public double Size(double parcent)
        {
            return parcent;
        }
    }
    public class Square : Resizeable
    {
        public void Resize(double parcent)
        {
            parcent = parcent * new Random().Next(1, 100);
            Console.WriteLine($"kích thước Squale tăng lên: {parcent}");
        }
        public double Size(double parcent)
        {
            return parcent;
        }
    }
}
