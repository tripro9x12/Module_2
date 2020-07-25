using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace JsonDemo
{
    class ScoreManagement
    {
        public static void Main()
        {
            var input = @"D:\C0520G1\Module_2\FileDemo\JsonDemo\Data\score.json";
            var output = @"D:\C0520G1\Module_2\FileDemo\JsonDemo\Data\process_score.json";
            var result = new Data();
            using(StreamReader sr = File.OpenText(input))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            Console.WriteLine("Name\t\tAge\t\tGender\t\tMath\t\tPhysical\tChemistry\tAverageScore");
            foreach(var item in result.students)
            {
                Console.WriteLine(item.ToString());
            }


            //ghi file;
            var response = new Response()
            {
                students = new List<resStudent>()
            };

            foreach(var item in result.students)
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
            using(StreamWriter sw = File.CreateText(output))
            {
                var data = JsonConvert.SerializeObject(response);
                sw.WriteLine(data);
            }

            Console.ReadKey();

        }
    }
    class Data
    {
        public List<Student> students { get; set; }
    }
    public class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<Score> scores { get; set; }

        public double AverageScore()
        {
            double total = 0;
            foreach(var item in scores)
            {
                if(item.name == "Toan")
                {
                    total += item.score*2;
                }
                else
                {
                    total += item.score;
                }
            }
            return total / (scores.Count + 1);
        }

        public override string ToString()
        {
            return $"{name}\t\t{age}\t\t{gender}\t\t{scores[0].score}\t\t{scores[1].score}\t\t{scores[2].score}\t\t{AverageScore()}";
        }
    }
    public class Score
    {
        public string name { get; set; }
        public double score { get; set; }
    }

    public class Response
    {
        public List<resStudent> students { get; set; }
    }
    public class resStudent : Student
    {
        public double average { get; set; }
        public string rank => Rank();
        private string Rank()
        {
            if (average >= 9)
            {
                return "Xuat sac";
            }
            if (average >= 8)
            {
                return "Gioi";
            }
            if (average >= 7)
            {
                return "Kha";
            }
            if (average >= 5)
            {
                return "TB";
            }
            return "Yeu";
        }

    }
}
