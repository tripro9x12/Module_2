using System;
namespace Students_Update {
    public class Student {
        private int id;
        private string name;
        private string address;
        private int age;
        public Student (int _id, string _name, string _address, int _age) {
            this.id = _id;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }

        public Student () { }

        public int ID {
            get => this.id;
            set => this.id = value;
        }
        public string NAME {
            get => this.name;
            set => this.name = value;
        }
        public string ADDRESS {
            get => this.address;
            set => this.address = value;
        }
        public int AGE {
            get => this.age;
            set => this.age = value;
        }

        public override string ToString () {
            return $"id: {this.id}, name: {this.name}, address: {this.address}, age: {this.age}";
        }

    }
}