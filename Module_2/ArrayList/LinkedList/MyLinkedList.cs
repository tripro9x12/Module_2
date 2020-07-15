using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList
    {
        Node Head;
        int NodeCount = 0;

        public MyLinkedList()
        {
        }

        public MyLinkedList(Object Data)
        {
            this.Head = new Node(Data);
        }

        public void Add(Object Data, int index)
        {
            Node temp = Head;
            Node holder;
            for(int i = 0;i<index - 1 && temp.Next != null; i++)
            {
                temp = temp.Next;
            }
            holder = temp.Next;
            temp.Next = new Node(Data);
            temp.Next.Next = holder;
            NodeCount++;
        }
        public void AddFirst(Object Data)
        {
            Node temp = Head;
            Head = new Node(Data);
            Head.Next = temp;
            NodeCount++;
        }

        public Node GetNode(int index)
        {
            Node temp = Head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public void PrintList()
        {
            Node temp = Head;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

    }
}
