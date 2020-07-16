using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public override string ToString()
        {
            return $"{StudentId}\t{StudentName}";
        }
    }
}
