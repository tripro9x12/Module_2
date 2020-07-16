using System;
using System.Collections.Generic;
using System.Text;

namespace Phone
{
    public class Contact
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name = {Name} | Phone = {PhoneNumber}";
        }
    }
}
