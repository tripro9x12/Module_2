using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_2
{
    public class Response
    {
        public List<resStudent> students { get; set; }
    }
    public class resStudent : Student
    {
        public double average { get; set; }
        public string rank => Rank();
        private string Rank()
        {
            if (average >= 9)
            {
                return "Xuat sac";
            }
            if (average >= 8)
            {
                return "Gioi";
            }
            if (average >= 7)
            {
                return "Kha";
            }
            if (average >= 6.5)
            {
                return "TB Kha";
            }
            if (average >= 5)
            {
                return "TB";
            }
            if (average >= 3.5)
            {
                return "yeu";
            }
            return "Kem";
        }

    }
}
