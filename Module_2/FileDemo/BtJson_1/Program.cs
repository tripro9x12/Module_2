using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BtJson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = @"D:\C0520G1\Module_2\FileDemo\BtJson_1\Data\input.json";
            var output1 =  @"D:\C0520G1\Module_2\FileDemo\BtJson_1\Data\output_1.json";
            var output2 =  @"D:\C0520G1\Module_2\FileDemo\BtJson_1\Data\output_2.json";
            //foreach(var item in ReadFile(input).NameProperty)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            var data = ReadFile(input);
            WriteFileSum(output1, data);
            WriteFileDouble(output2, data);
        }
        public static Data ReadFile(string input)
        {
            var result = new Data();
            using(StreamReader sr = File.OpenText(input))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            return result;
        }
        public static void WriteFileSum(string output,Data data)
        {
            var dataSum = new DataSum()
            {
                NameProperty = new List<AddMethodSum>()
            };
            foreach(var item in data.NameProperty)
            {
                dataSum.NameProperty.Add(new AddMethodSum()
                {
                    a = item.a,
                    b = item.b,
                    c = item.c,
                    sum = item.Sum()
                }) ;
            }
            using(StreamWriter sw = File.CreateText(output))
            {
                var newdata = JsonConvert.SerializeObject(dataSum);
                sw.WriteLine(newdata);
            }
         
        }
        public static void WriteFileDouble(string output,Data data)
        {
            var datadouble = new DataDouble()
            {
                NameProperty = new List<AddMethodDataDouble>()
            };
            foreach(var item in data.NameProperty)
            {
                datadouble.NameProperty.Add(new AddMethodDataDouble()
                {
                    a = item.a,
                    b = item.b,
                    c = item.c
                });
            }
            using(StreamWriter sw = File.CreateText(output))
            {
                var newdata = JsonConvert.SerializeObject(datadouble);
                sw.WriteLine(newdata);
            }
        }
    }
}
