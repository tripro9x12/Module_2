using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementCart
{
    public class Data
    {
        public List<MProduct> Cart { get; set; }
        public int IndexNameProduct(string name)
        {       
            for(int i = 0;i<Cart.Count;i++)
            {
                if(Cart[i].Name == name)
                {
                    return i;
                }
            }
            return -1;         
        }
    }
    public class MProduct
    {
        public string Name { get; set; }
        public int Money { get; set; }
        private int count = 0;
        public int Count
        {
            get => count;
            set => count = value;
        }
        public int sum => Sum();
        private int Sum()
        {
            int total = 0;
            total = count * Money;
            return total;
        }
        public override string ToString()
        {
            return $"{Name}\t\t\t{Count}\t\t{Money}\t\t\t{sum}";
        }
    }
}
