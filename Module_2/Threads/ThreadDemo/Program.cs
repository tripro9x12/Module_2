using System;
using System.Threading;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator num_1 = new NumberGenerator("Thread 1");
            Thread thread_1 = new Thread(num_1.Run);
            thread_1.Priority = ThreadPriority.Highest;
            thread_1.Start();

            NumberGenerator num_2 = new NumberGenerator("Thread 2");
            Thread thread_2 = new Thread(num_2.Run);
            thread_2.Priority = ThreadPriority.Lowest;
            thread_2.Start();


        }

    }
    public class NumberGenerator
    {
        public string Name { get; set; }
        public NumberGenerator(string name)
        {
            this.Name = name;
        }
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{this.Name}: {i}");
                Thread.Sleep(500);
            }
        }
    }
}
