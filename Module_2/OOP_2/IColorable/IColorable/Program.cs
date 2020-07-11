using System;

namespace IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[2];


            Square square = new Square(3);
            Rectangle rec = new Rectangle(3, 4);
            
            shape[0] = square;
            shape[1] = rec;
            for(int i = 0; i < shape.Length; i++)
            {
                Console.Write(shape[i].Name() + " ");
                Console.WriteLine(shape[i].GetArea());
                if (shape[i] is Icolorabale)
                {
                    shape[i].HowToColor();
                }
          
            }


        }
    }
}
