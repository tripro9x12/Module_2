using System;

namespace Phone
{
    class PhoneManagement
    {
        public static PhoneService phoneservice = new PhoneService();
        public static void Main()
        {
            phoneservice.Add(new Contact()
            {
                Name = "Tri",
                PhoneNumber = 113
            });

            phoneservice.Add(new Contact()
            {
                Name = "My",
                PhoneNumber = 114
            });
            phoneservice.Add(new Contact()
            {
                Name = "An",
                PhoneNumber = 115
            });

            phoneservice.Show();
        }
    }
}
