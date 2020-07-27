using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace BtJson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = @"D:\C0520G1\Module_2\FileDemo\BtJson_2\Data\data.json";
            var output = @"D:\C0520G1\Module_2\FileDemo\BtJson_2\Data\outcome.json";
            var data = ReadFile(input);
            Console.WriteLine("Name\t\tAge\t\tGender\t\tMath\t\tPhysical\tChemistry\tAverageScore");
            foreach (var item in data.students)
            {
                Console.WriteLine(item.ToString());
            }
            WriteFile(output,data);
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
        public static void WriteFile(string output,Data data)
        {
            var response = new Response()
            {
                students = new List<resStudent>()
            };
            foreach(var item in data.students)
            {
                response.students.Add(new resStudent()
                {
                    name = item.name,
                    age = item.age,
                    gender = item.gender,
                    scores = item.scores,
                    average = item.AverageScore()
                });
            }
            response.students.Sort(new SortStudent<resStudent>());
            using (StreamWriter sw = File.CreateText(output))
            {
                var newdata = JsonConvert.SerializeObject(response);
                sw.WriteLine(newdata);
            }
        }
    }
    public class SortStudent<T> : IComparer<resStudent>
    {
        int IComparer<resStudent>.Compare(resStudent x, resStudent y)
        {
            if (x.average < y.average)
            {
                return 1;
            }
            else if (x.average == y.average)
            {
                return 0;
            }
            else return -1;
        }
    }
}
