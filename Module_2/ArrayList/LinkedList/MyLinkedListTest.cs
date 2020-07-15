using System;

namespace LinkedList
{
    class MyLinkedListTest
    {
        static void Main()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddFirst(13);
            myLinkedList.AddFirst(12);
            myLinkedList.AddFirst(11);
            myLinkedList.Add(9, 4);
            myLinkedList.Add(10, 4);
            myLinkedList.PrintList();


        }
    }
}
