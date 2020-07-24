using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace BtFile_2
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\BtFile_2\Data";
            Directory.CreateDirectory(path);
            var data = "data.txt";
            var output = "output.txt";

            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = Int32.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10,70);
                }
            }

            WriteFile($@"{path}\{data}",array);
            int[,] newarray = new int[0, 0];
            ReadFile($@"{path}\{data}",ref newarray);
            NewWriteFile($@"{path}\{output}", newarray);
        }
        public static void WriteFile(string path, int[,] array)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        var data = string.Join(" ", array[i, j]);
                        sw.Write(data + " ");
                    }
                    sw.WriteLine();
                }
            }
        }
        public static void ReadFile(string path,ref int[,] array)
        {

            using (StreamReader sr = File.OpenText(path))
            {
                List<string[]> dataString = new List<string[]>();
                var line = string.Empty;

                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(" ");
                        dataString.Add(data);

                    }
                    array = new int[dataString.Count, dataString[0].Length-1];
                    for (int i = 0; i < dataString.Count; i++)
                    {

                        for (int j = 0; j < dataString[i].Length-1; j++)
                        {
                            array[i, j] = Int32.Parse(dataString[i][j]);
                        }
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine(e.GetType().Name);
                }

            }
        }
        public static void NewWriteFile(string path, int[,] array)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("so chan: ");
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 2 == 0)
                        {
                            sw.Write(array[i, j] + " ");
                        }
                    }
                }
                sw.WriteLine();
                sw.WriteLine("boi so cua 5: ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] % 5 == 0)
                        {
                            sw.Write(array[i, j] + " ");
                        }
                    }
                }
            }

        }
    }
    
}
