using System;

namespace Students_Update {
    class Program {
        static void Main (string[] args) {
            Student student1 = new Student (1, "M. Công", "Hà Nội", 30);

            Student student2 = new Student ();
            student2.ID = 2;
            student2.NAME = "Trí";
            student2.ADDRESS = "Huế";
            student2.AGE = 23;
            Console.WriteLine (student1.ToString ());
            Console.WriteLine (student2.ToString ());
            Console.ReadKey ();
        }

    }
}