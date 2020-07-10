using System;

namespace CountCharInString {
    class Program {
        static void Main (string[] args) {
            int count = 0;
            string str = "hoc lap trinh csharp";
            Console.Write ("Nhập ký tự muốn đếm: ");
            char c = Char.Parse (Console.ReadLine ());

            for (int i = 0; i < str.Length; i++) {
                if (str[i] == c) {
                    count++;
                }
            }
            Console.WriteLine ($"count = {count}");
        }
    }
}