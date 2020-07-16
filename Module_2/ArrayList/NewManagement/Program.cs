using System;
using System.Collections;
using System.Collections.Generic;

namespace NewManagement
{
    class Program
    {
        public static List<News> newList = new List<News>();
        public static int increment = 0;
        static void Main(string[] args)
        {
            int choice;
            string Y = "Y";
            while(Y == "Y"){
                Console.WriteLine("1.InsertNews");
                Console.WriteLine("2.ViewListNews");
                Console.WriteLine("3.AverageRate");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Moi Ban Nhap Lua Chon");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertNews();
                        break;
                    case 2:
                        ViewListNews();
                        break;
                    case 3:
                        AverageRate();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Ban Muon Tiep Tuc Khong: Y/N");
                Y = Console.ReadLine();
                Console.WriteLine("--------------------------------------");
            }
        }

        public static void InsertNews()
        {
            increment++;
            var news = new News();
            news.Id = increment;
            Console.Write("Title: ");
            news.Title = Console.ReadLine();
            Console.Write("Publish date: ");
            news.PublishDate = Console.ReadLine();
            Console.Write("Author: ");
            news.Author = Console.ReadLine();
            Console.Write("Content: ");
            news.Content = Console.ReadLine();

            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.Write($"Rate {i + 1}: ");
                string num = Console.ReadLine();
                while(!Int32.TryParse(num, out news.RateList[i]) || (news.RateList[i] < 0 || news.RateList[i] > 5 )  )
                {
                    Console.Write($"Nhap Lai 1 so 1-5: ");
                    num = Console.ReadLine();
                }
            }
            newList.Add(news);
        }

        public static void ViewListNews()
        {
            Console.WriteLine($"Id\tTitle\tPublish Date\tAuthor\t\tContent\t\tAverageRate");
            foreach (var news in newList)
            {
                news.Display();
            }
        }

        public static void AverageRate()
        {
            foreach (var news in newList)
            {
                news.Calculate();
            }
        }
    }
}
