using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_3
{
    public class NewData
    {
        public List<NewCoffee> MCoffee { get; set; }
    }
    public class NewCoffee : Coffee
    {
        public int SumAllItems => SUMALLITEMS();
        private int SUMALLITEMS()
        {
            var result = 0;
            foreach (var item in items)
            {
                result += item.sum;
            }
            return result;
        }
    }
}
