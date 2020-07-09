using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2d = new Point2D(0.5f, 0.6f);
            point2d.setXY(0.4f, 0.5f);
            Console.WriteLine("Arr point1");
            for (int i = 0; i< point2d.getXY().Length; i++)
            {
                Console.WriteLine(point2d.getXY()[i]);
            }



            Point3D point3d = new Point3D();
            point3d.setXZY(4.5f, 5f, 6f);
            Console.WriteLine("Arr point2");
            for (int i = 0; i < point3d.getXYZ().Length; i++)
            {
                Console.WriteLine(point3d.getXYZ()[i]);
            }


            MoveablePoint moveablePoint = new MoveablePoint(0f,0f,4f,6f);
        
            moveablePoint.xSpeed = 5f;
            moveablePoint.YSpeed = 4f;
            Console.WriteLine("arr moveablePoint");
            for(int i = 0; i<moveablePoint.GetSpeed().Length; i++)
            {
                Console.Write("index: "+ i+" = "+moveablePoint.GetSpeed()[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine(moveablePoint.ToString());

            Console.WriteLine($"xSpeed = {moveablePoint.xSpeed},ySpeed = {moveablePoint.ySpeed}");

            Console.WriteLine(moveablePoint.Move());

            Console.ReadKey();
        }
    }
}
