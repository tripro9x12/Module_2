using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_1
{
    public class DataSum
    {
        public List<AddMethodSum> NameProperty { get; set; }
    }
    public class AddMethodSum : DemoProperty
    {
        public int sum { get; set; }
       
    }
}
