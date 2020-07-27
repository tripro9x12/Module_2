using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_1
{
    public class DataDouble
    {
        public List<AddMethodDataDouble> NameProperty { get; set; }
    }
    public class AddMethodDataDouble : DemoProperty
    {
        public int A
        {
            get => a * 2;
            set => a = value;
        }
        public int B
        {
            get => b * 2;
            set => b = value;
        }
        public int C
        {
            get => c * 2;
            set => c = value;
        }
    }
}
