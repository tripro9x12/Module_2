using System;

namespace AnimalNS {
    class Program {
        static void Main (string[] args) {
            Cat cat = new Cat ("20kg", "1.5m", "Tom");
            cat.PrintInfo ();
        }
    }
}