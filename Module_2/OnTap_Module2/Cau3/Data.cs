using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3
{
    class Data
    {
        public string emailOfManagement => ("Admin").ToUpper();
        private string PassWord = "123456789";
        public string password
        {
            get => PassWord.ToUpper();
            set => PassWord = value;
        }
        public List<MemberManagement> member { get; set; }
        public List<OdersManagement> oders { get; set; }
        public List<ProductAllManagement> ProductAll { get; set; }
        public int IndexStatus()
        {
            for(int i = 0;i< oders.Count; i++)
            {
                if(oders[i].status == "isPay")
                {
                    return i;
                }
            }
            return -1;          
        }
    }
    class MemberManagement
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public override string ToString()
        {
            return $"{name}\t{email}\t{password}\t{phone}\t{address}";
        }
    }
    class OdersManagement
    {
        public string odersCode { get; set; }
        public string nameCustomer { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        private string Status = "accept the application";
        public string status
        {
            get => Status;
            set => Status = value;
        }
        public string dateTime => DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        public List<OdersProduct> product { get; set; }
        public long sumAllProduct => SumAllProduct();
        private long SumAllProduct()
        {
            long total = 0;
            foreach(var item in product)
            {
                total += item.sumPrice;
            }
            return total;
        }
        public override string ToString()
        {
            return $"{odersCode}\t{nameCustomer}\t{address}\t{phone}\t{status}\t{dateTime}\t";
        }
    }
    class OdersProduct
    {
        public string code { get; set; }
        public string name { get; set; }
        private int Count = 0;
        public int count
        {
            get => Count;
            set => Count = value;
        }
        public int price { get; set; }
        public long sumPrice => count * price;
    }
    class ProductAllManagement
    {
        public string code { get; set; }
        public string name { get; set; }
        private int Count = 0;
        public int count
        {
            get => Count;
            set => Count = value;
        }
        public int priceIn { get; set; }
        public int priceOut { get; set; }
        public long sumPriceIn => count * priceIn;
        public long sumPriceOut => count * priceOut;
        public long excessCash => sumPriceOut - sumPriceIn;
        public override string ToString()
        {
            return $"{code}\t{name}\t{count}\t{priceIn}\t{priceOut}\t{sumPriceIn}\t{sumPriceOut}";
        }

    }
}
