using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Phone
{
    public class PhoneService
    {
        public Hashtable PhoneList = new Hashtable();
        public void Add(Contact contact)
        {
            PhoneList.Add(contact.Name,contact);
        }

        public void Show()
        {
            Console.WriteLine("Name\t\t PhoneNumber");
            foreach(var value in PhoneList.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
