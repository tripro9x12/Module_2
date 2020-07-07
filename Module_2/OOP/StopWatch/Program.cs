using System;
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();
            StopWatch_ch st = new StopWatch_ch();
            int[] arr = new int[1000];

            st.InputArr(ref arr);
            Console.WriteLine(st.Start());
            st.SortArr(ref arr);
            st.ShowArr(arr);

            Console.WriteLine(st.End());
            Console.WriteLine(st.GetElapsedTime());
        }
    }
}
