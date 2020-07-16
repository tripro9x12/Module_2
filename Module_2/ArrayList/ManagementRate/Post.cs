using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementRate
{
    public class Post : IPost
    {
        private int id;
        private string title;
        private string author;
        private string content;
        private float averageRate;
        public int[] Rates = new int[3];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public float AverageRate { get => averageRate;}
        public int Count { get => Rates.Length; }

       

        public void Display()
        {
            Console.WriteLine($"{this.Id}\t{this.Title}\t{this.Content}\t{this.Author}\t{this.Count}\t{this.AverageRate}");
        }
        public void CalculatorRate()
        {
            int total = 0;
            foreach(int i in Rates)
            {
                total += i;
            }
            averageRate = total / Rates.Length;
        }
    }
}
