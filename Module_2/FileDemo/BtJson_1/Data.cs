using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_1
{
    public class Data
    {
        public List<DemoProperty> NameProperty { get; set; }
    }
    public class DemoProperty
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public override string ToString()
        {
            return $"{a}\t{b}\t{c}";
        }
        public int Sum()
        {
            var resutl = this.a + this.b + this.c;
            return resutl;
        }
        
    }
}
