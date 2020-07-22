using System;
using System.IO;
using System.Collections.Generic;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\FileDemo\Data"; //@ vô hiệu quá "/";
            Directory.CreateDirectory(path);
            //Directory.Delete(path);

            var filename = "input.txt";
            //using (StreamWriter sw = File.CreateText($@"{path}\{filename}"))
            //{
            //    sw.WriteLine("CodeGym Huế");
            //    sw.WriteLine("C0520G1");
            //}

            //List<string> data = new List<string>();
            //using (StreamReader sr = File.OpenText($@"{path}\{filename}"))
            //{
            //    //Console.WriteLine(sr.ReadToEnd());
            //    var line = string.Empty;
            //    int number = 0;
            //    while((line = sr.ReadLine())!= null)
            //    {
            //        number+=1;
            //        //Console.WriteLine($"Line {number}: {line.ToUpper()}");
            //        data.Add($"Line {number}: {line.ToUpper()}");
            //    }
            //}
            var data = FileHelper.ReadFile($@"{path}\{filename}");
            var outputFileName = "output.txt";
            FileHelper.WriteFile($@"{path}\{outputFileName}",data);
            //using(StreamWriter sw = File.CreateText($@"{path}\{outputFileName}"))
            //{
            //    foreach(var item in data)
            //    {
            //        sw.WriteLine(item);
            //    }
            //}

            //var logpath = @"D:\C0520G1\Module_2\FileDemo\FileDemo\logs";
            //Directory.CreateDirectory(logpath);
            //var logFileName = $"Log_{DateTime.Now.ToString("ddMMyyyyhhmm")}.txt";
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    Console.WriteLine($"{a}/{b} = {a / b}");
            //}
            //catch (Exception e)
            //{

            //    using (StreamWriter sw = File.AppendText($@"{logpath}\{logFileName}"))
            //    {
            //        sw.WriteLine($"Error {DateTime.Now.ToString("dd/MM/yyyy/hh:mm: ")} {e.Message}");
            //    }
            //}
            var arrayInput = @"D:\C0520G1\Module_2\FileDemo\FileDemo\Data\ArrayInput.txt";
            var arrayOutput = @"D:\C0520G1\Module_2\FileDemo\FileDemo\Data\ArrayOutput.txt";
            int[] array = new int[0];

            using(StreamReader sr = File.OpenText(arrayInput))
            {
                var line = string.Empty;
                while((line = sr.ReadLine()) != null)
                {
                    string[] dataa = line.Split(' ');
                    array = new int[dataa.Length];
                    for(int i = 0; i < array.Length;i++)
                    {
                        array[i] = Int32.Parse(dataa[i]);
                    }
                }
            }
            using(StreamWriter sw = File.CreateText(arrayOutput))
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] *= 2;
                }
                var dataa = string.Join(' ', array);
                sw.WriteLine(dataa);
            }

        }
    }
}
