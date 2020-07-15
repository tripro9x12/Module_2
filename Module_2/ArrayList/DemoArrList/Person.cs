using System;
using System.Collections.Generic;
using System.Text;

namespace DemoArrList
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string NAME
        {
            get => this.Name;
            set => this.Name = value;
        }
        
        public int AGE
        {
            get => this.Age;
            set => this.Age = value;
        }
        public override string ToString()
        {
            return $"Name: {this.Name} | Age: {this.Age}";
        }
    }
}
