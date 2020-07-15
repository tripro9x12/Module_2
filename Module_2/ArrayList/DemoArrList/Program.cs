using System;
using System.Collections;
using System.Text;

namespace DemoArrList
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arraylist
            ArrayList arrayList = new ArrayList();  // khởi tạo 1 arraylist rỗng

            //capacity : kích thước mảng;
            ArrayList arrayList_2 = new ArrayList(5); //khởi tạo arraylist có kích thước là 5: capacity;


            //sao chép arraylist
            ArrayList arrayList_3 = new ArrayList(arrayList_2);  //clone, tạo ra 1 vùng nhớ mới;
            ArrayList arrayList_4 = arrayList_2;

            
            #endregion
            #region Arraylist Person
            ArrayList arrPersons = new ArrayList();

            arrPersons.Add(new Person("Trí",23));
            arrPersons.Add(new Person("Thạnh", 17));
            arrPersons.Add(new Person("Buồn", 25));

            foreach(Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            //sắp xếp Sort;
            arrPersons.Sort(new SortPersons());
            Console.WriteLine("\n danh sách sau khi sắp xếp");
            foreach(Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

           



            Console.ReadKey();

        }
        public class SortPersons : IComparer
        {
            public int Compare(object x, object y)
            {
                Person p1 = x as Person;
                Person p2 = y as Person;
                if(p1 == null || p2 == null)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    if(p1.AGE > p2.AGE)
                    {
                        return 1;
                    }else if(p1.AGE == p2.AGE){
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}
