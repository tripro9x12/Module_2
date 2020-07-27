using System;
using System.Collections.Generic;
using System.Text;

namespace BtJson_2
{
    public class Data
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
            foreach (var item in scores)
            {
                if (item.name == "Toan")
                {
                    total += item.score * 2;
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
}
