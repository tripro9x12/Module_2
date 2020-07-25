using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\JsonDemo\Data\matrix.json";
            var result = new Data();
            using (StreamReader sr = File.OpenText(path))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            foreach(var item in result.matrix)
            {
                foreach(var number in item)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            foreach(var item in result.array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Name\tAge\tGender\tDateOfBirth");
            foreach(var item in result.employees)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
    class Data
    {
        public List<List<int>> matrix { get; set; }
        public List<int> array { get; set; }
        public List<Employees> employees { get; set; }
    }
    class Employees
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public override string ToString()
        {
            return $"{name}\t{age}\t{gender}\t{dob}";
        }
    }
}
