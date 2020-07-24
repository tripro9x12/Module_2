using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace BtFile_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\BtFile_1\Data";
            Directory.CreateDirectory(path);

            var arrayInput = "InputData.txt";
            var arrayOutput = "OutputData.txt";
            int[,] array = new int[0,0];
            FileHelper.WriteFile(@$"{path}\{arrayInput}");
            FileHelper.ReadFile(@$"{path}\{arrayInput}",ref array);
            FileHelper.NewWriteFile($@"{path}\{arrayOutput}", array);
        }
    }
    class FileHelper
    {
        public static void WriteFile(string path)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("1 3 10 7");
                sw.WriteLine("1 2 3 4");
                sw.WriteLine("2 4 6 8");
                sw.WriteLine("2 3 5 6");
            }
        }
        public static void ReadFile(string path, ref int[,] array)
        {
            using(StreamReader sr = File.OpenText(path))
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
                    array = new int[dataString.Count, dataString[0].Length];
                    for (int i = 0; i < dataString.Count; i++)
                    {

                        for (int j = 0; j < dataString[i].Length; j++)
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
        public static void NewWriteFile(string path,int[,] array)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] *= 2;                       
                    }
                }
                
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    string[] arr = new string[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        var data = string.Join("\n", array[i, j]);
                        arr[j] = data;
                       
                    }
                    for (int z = 0; z < arr.Length; z++)
                    {
                        var dataa = string.Join(" ", arr[z]);
                        sw.Write(dataa + " ");
                    }
                    sw.WriteLine();

                }
               
            }
        }
    }
}
