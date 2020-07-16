using System;

namespace ManagementRate
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int increment = 0;
        static void Main(string[] args)
        {
            int choice;
            string Y = "Y";
            while (Y == "Y")
            {
                Console.WriteLine("1.Create Post");
                Console.WriteLine("2.Update Post");
                Console.WriteLine("3.Remove Post");
                Console.WriteLine("4.Show Posts");
                Console.WriteLine("5.Search");
                Console.WriteLine("6.Rating");
                Console.WriteLine("7.Exit");

                Console.WriteLine("Moi Ban Nhap So De Lua Chon");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreatePost();
                        break;
                    case 2:
                        UpdatePost();
                        break;
                    case 3:
                        RemovePost();
                        break;
                    case 4:
                        ShowPost();
                        break;
                    case 5:
                        SearchPost();
                        break;
                    case 6:
                        Rating();
                        break;
                    case 7:
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Nhap Y de tiep tuc, Nhap phim bat ky de thoat.");
                Y = Console.ReadLine();
                Console.WriteLine("--------------------------------------");
            }
        }

        public static void CreatePost()
        {
            increment++;
            Post post = new Post();
            post.Id = increment;
            Console.Write("Title: ");
            post.Title = Console.ReadLine();
            Console.Write("Author: ");
            post.Author = Console.ReadLine();
            Console.Write("Content: ");
            post.Content = Console.ReadLine();

            for (int i = 0; i < post.Rates.Length; i++)
            {
                Console.Write($"Rate {i + 1}: ");
                string num = Console.ReadLine();
                while (!Int32.TryParse(num, out post.Rates[i]) || (post.Rates[i]  < 0 || post.Rates[i] > 5))
                {
                    Console.Write($"Nhap Lai 1 so 1-5: ");
                    num = Console.ReadLine();
                }
            }

            forum.Add(post);
        }
        public static void UpdatePost()
        {
            Console.Write("Nhap Id: ");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap Content: ");
            string content = Console.ReadLine();
            forum.UpdateContent(id, content);
        }

        public static void RemovePost()
        {
            Console.Write("Nhap Id: ");
            int id = Int32.Parse(Console.ReadLine());
            forum.Remove(id);
        }
        public static void ShowPost()
        {
            Console.WriteLine($"Id\tTitle\tContent\tAuthor\tCount\tAverageRate");
            forum.AverageRate();
            forum.Show();
        }

        public static void SearchPost()
        {
            Console.Write("Nhap Author: ");
            string author = Console.ReadLine();
            Console.Write("Nhap Title: ");
            string title = Console.ReadLine();
            forum.Search(author, title);
        }
        public static void Rating()
        {
            Console.Write("Nhap Id 1-5: ");
            int id = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= forum.Posts.Count; i++)
            {
                if(forum.Posts[i].Id == id)
                {
                    forum.Posts[i].Display();
                }
                else
                {
                    Console.WriteLine("Invalid Post");
                }
            }
        }
        

    }
}
