using System;

namespace ManagementRate
{
    class Program
    {
        public static Forum forum = new Forum();
        public static int increment = 0;
        static void Main(string[] args)
        {
            CreatePost();
            ShowPost();
            UpdatePost();
            ShowPost();
            Rating();
          
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
