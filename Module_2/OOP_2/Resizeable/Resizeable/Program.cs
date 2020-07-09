using System;

namespace Resizeable
{
    class Program
    {
        static void Main(string[] args)
        {
            Resizeable[] resizeables = new Resizeable[3];
            resizeables[0] = new Circle();
            resizeables[1] = new Rectangle();
            resizeables[2] = new Square();
            Console.WriteLine("Trước khi resize");
            for (int i = 0; i < resizeables.Length; i++)
            {
                Console.WriteLine(resizeables[i].Size(5));
            }
            Console.WriteLine("Sau khi resize");
            for (int i = 0; i < resizeables.Length; i++)
            {
                //Console.WriteLine(resizeables[i].Resize(5));
                resizeables[i].Resize(5);
            }
        }
    }
}
