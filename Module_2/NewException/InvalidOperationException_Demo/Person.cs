using System;
using System.Collections.Generic;
using System.Text;

namespace InvalidOperationException_Demo
{
    public class Person
    {
        private string _name { get; set; }
        private int _age { get; set; }
        private string _gender { get; set; }
        public Person()
        {

        }
        public Person(string name,int age,string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public override string ToString()
        {
            return $"Name = {Name}| Age = {Age} | Gender = {Gender}";
        }

    }
}
