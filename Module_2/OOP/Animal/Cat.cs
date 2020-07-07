using System;
namespace AnimalNS {
    public class Cat : Animal {
        private string Name { get; set; }
        public Cat (string weight, string height, string name) : base (weight, height) {
            this.Name = name;
        }
        public override void PrintInfo () {
            Console.WriteLine ($"name: {this.Name}, weight: {this.Weight}, height: {this.Height}");
        }
    }
}