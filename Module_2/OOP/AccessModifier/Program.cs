using System;

namespace AccessModifier {
    class Program {
        static void Main (string[] args) {
            PublicLib.Class1 pc = new PublicLib.Class1 ();
            int sum = pc.Sum (1, 2);

            InternalLib.Class1 ic = new InternalLib.Class1 ();
            sum = ic.Sum (1, 2);
        }
    }
}