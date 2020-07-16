using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class QueueDemo
    {
        public static void Main()
        {
            Queue queue = new Queue();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}
            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(queue.Count);
        }
    }
}
