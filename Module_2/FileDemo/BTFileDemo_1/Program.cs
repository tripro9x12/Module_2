using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace BTFileDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\BTFileDemo_1\Data";
            Directory.CreateDirectory(path);

            var arrayInput = "InputData.txt";
            var arrayOutput = "OutputData.txt";
            
        }
    }
     class File
    {
        public void WriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("1 3 4 6");
            }
        }
    }
}
