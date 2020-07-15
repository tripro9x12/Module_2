using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class MyList<T>
    {
        private int Capacity { get; set; }
        private Object[] Items;
        public MyList()
        {
            Items = new Object[10];
        }
        private void EnsureCapacity()
        {
            int newSize = Items.Length * 2;
            Array.Copy(Items, Items, newSize);
        }

        public void Add(T Data)
        {
            if(this.Capacity == Items.Length)
            {
                EnsureCapacity();
            }
             Items[this.Capacity++] = Data;
        }
        public T GetDaTa(int index)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new IndexOutOfRangeException("Index: " + index + ", Capacity: " + this.Capacity);
            }
            return (T)Items[index];
        }


    }
}
