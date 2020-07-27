using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_3
{
    public class Data
    {
        public List<Coffee> MCoffee { get; set; }
        public int checkTable(int table)
        {
            for(int i = 0; i < MCoffee.Count; i++)
            {
                if (MCoffee[i].Table == table)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public class Coffee
    {
        public int Table { get; set; }
        private bool Pay = false;
        public bool PAY
        {
            get => Pay;
            set => Pay = value;
        }
        public List<Item> items { get; set; }
     
       
        public override string ToString()
        {
            return $"{Table}\t{PAY}\t{items[0].name}\t{items[0].money}\t{items[0].Count}\t{items[0].sum}";
        }
    }
    public class Item
    {
        public string name { get; set; }
        public int money { get; set; }
        private int count = 0;
        public int Count
        {
            get => count;
            set => count = value;
        }
        public int sum => Sum();
        private int Sum()
        {
            var total = 0;
            for(int i = 0; i < count; i++)
            {
                total += money;
            }
            return total;
        }
    }
}
