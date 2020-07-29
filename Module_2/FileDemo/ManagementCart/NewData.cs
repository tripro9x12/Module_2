using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementCart
{
    public class NewData : Data
    {
        public int SumAllProduct => SUMALLPRODUCT();
        private int SUMALLPRODUCT()
        {
            var total = 0;
            foreach (var item in Cart)
            {
                total += item.sum;
            }
            return total;
        }
        public bool Pay => true;
        public string DateTimePay => DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
    }
}
   
    

