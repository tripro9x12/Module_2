using System;

namespace ReduceArr {
    class Program {
        static void Main (string[] args) {
            Console.Write ("Nhập số lượng phần tử arr_1: ");
            int n_1 = Int32.Parse (Console.ReadLine ());
            int[] arr_1 = new int[n_1];
            Console.WriteLine ("Nhập arr 1:");
            for (int i = 0; i < arr_1.Length; i++) {
                Console.Write ($"arr[{i}]: ");
                arr_1[i] = Int32.Parse (Console.ReadLine ());
            }

            Console.Write ("Nhập số lượng phần tử arr_2: ");
            int n_2 = Int32.Parse (Console.ReadLine ());
            int[] arr_2 = new int[n_2];

            Console.WriteLine ("Nhập arr 2:");
            for (int i = 0; i < arr_2.Length; i++) {
                Console.Write ($"arr[{i}]: ");
                arr_2[i] = Int32.Parse (Console.ReadLine ());
            }

            int n_3 = n_1 + n_2;
            int[] arr_3 = new int[n_3];
            for (int i = 0; i < arr_1.Length; i++) {
                arr_3[i] = arr_1[i];
            }
            for (int i = 0; i < arr_2.Length; i++) {
                arr_3[arr_1.Length + i] = arr_2[i];
            }

            Console.WriteLine ("các phần tử của arr_3");
            for (int i = 0; i < arr_3.Length; i++) {
                Console.WriteLine ($"index {i}: {arr_3[i]}");
            }
        }
    }
}