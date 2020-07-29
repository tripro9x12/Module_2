using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadDemo
{
    public class TestThread
    {
        public static void Main()
        {
            OddThread odd = new OddThread();
            Thread thread_odd = new Thread(odd.Run);
            thread_odd.Start();
            thread_odd.Join();
            EvenThread even = new EvenThread();
            Thread thread_even = new Thread(even.Run);
            thread_even.Start();
        }
    }
    public class OddThread
    {
        public void Run()
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(10);
                }
            }
        }
    }
    public class EvenThread
    {
        public void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(15);
                }
            }
        }
    }
}
