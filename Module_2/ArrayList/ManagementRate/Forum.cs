using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ManagementRate
{
    public class Forum
    {
        public SortedList<int, Post> Posts = new SortedList<int, Post>();

        public void Add(Post post)
        {
            Posts.Add(post.Id, post);
        }
        public void UpdateContent(int id, string content)
        {
            for(int i = 1; i <= Posts.Count; i++)
            {
                if(id == Posts[i].Id)
                {
                    Posts[i].Content = content;
                }
            }
            
        }
        public void Remove(int id)
        {
            Posts.Remove(id);

            //for (int i = 1; i <= Posts.Count; i++)
            //{
            //    if(Posts[i].Id == id)
            //    {
            //        for(int j = i; j < Posts.Count; j++)
            //        {
            //            Posts[j] = Posts[j + 1];
            //        }
            //    }
            //}
            //Posts.Remove(Posts.Count - 1);

        }
        public void Show()
        {
            
            foreach(var item in Posts.Values)
            {
                item.Display();
            }
        }

        public void Search(string author, string title)
        {
            for(int i = 1; i <= Posts.Count;i++)
            {
                if(Posts[i].Author == author || Posts[i].Title == title)
                {
                    Posts[i].Display();
                }
            }
        }
        public void AverageRate()
        {
            foreach(var item in Posts.Values)
            {
                item.CalculatorRate();
            }
        }
        //public int Find(int id)
        //{
        //    for(int i = 1; i <= Posts.Count; i++)
        //    {
        //        if(i+1 == id)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
    }
}
