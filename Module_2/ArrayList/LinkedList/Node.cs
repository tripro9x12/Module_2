using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public Object Data { get; set; }
        public Node Next { get; set; }
        public Node(Object Data)
        {
            this.Data = Data;
            this.Next = null;
        }
    }
}
