using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ManagementCart
{
    class Program
    {
        public const int _CreateProduc = 1;
        public const int _WriteFileJson = 2;
        public const int _SeeCart = 3;
        public const int _RemoveNameProduct = 4;
        public const int _Pay = 5;
        public const int _Exit = 6;
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\ManagementCart\Data";
            Directory.CreateDirectory(path);
            var input = "input.json";
            string time = DateTime.Now.ToString("dd_MM_yyyy_hh_mm");
            var output = "Bill";
            Data data = new Data();      

            //Meunu
            string y = "Y";
            int choice;
            while (y == "Y")
            {
                Console.WriteLine("1. Create Product");
                Console.WriteLine("2. Write Create Product To FileJson");
                Console.WriteLine("3. See Product In Cart");
                Console.WriteLine("4. Remove Name Product");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Exit");

                Console.Write("Moi Ban Lua Chon: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case _CreateProduc:
                        data = CreateProduct($@"{path}\{input}");
                        break;
                    case _WriteFileJson:
                        WriteCreateProduct($@"{path}\{input}", data);
                        break;
                    case _SeeCart:
                        SeeProductInCart(data);
                        break;
                    case _RemoveNameProduct:
                        RemoveNameProduct($@"{path}\{input}", data);
                        break;
                    case _Pay:
                        Pay($@"{path}\{input}", $@"{path}\{output}_{time}.json", data);
                        break;
                    case _Exit:
                        break;
                    default:
                        Console.WriteLine("Nhap sai, moi nhap lai: ");
                        break;
                }
                Console.WriteLine("Nhap y de tiep tuc,nhap bat ky de thoat....");
                y = Console.ReadLine().ToUpper();
            }
        }
        public static Data CreateProduct(string input)
        {
            bool check = true;
            var result = new Data();
            using(StreamReader sr = File.OpenText(input))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            Console.Write("Enter Name Product: ");
            string name = Console.ReadLine().ToUpper();
            Console.Write("Enter Count: ");
            string num = Console.ReadLine();
            int count;
            if(!(int.TryParse(num,out count)) || count < 0)
            {
                Console.WriteLine(" Enter Count > 0 And Count Not String: ");
                num = Console.ReadLine();
            }
            Console.Write("Enter Money In One Name Product: ");
            int money;
            string moneyy = Console.ReadLine();
            if(!(int.TryParse(moneyy,out money)) || money < 0)
            {
                Console.WriteLine(" Enter Money > 0 And Money Not String: ");
                moneyy = Console.ReadLine();
            }
            foreach (var items in result.Cart)
            {
                if (items.Name == name)
                {
                    check = false;
                    items.Count += count;
                }
            }
            if (check)
            {
                result.Cart.Add(new MProduct()
                {
                    Name = name,
                    Count = count,
                    Money = money
                });
            }
            return result;
           
        }
        public static void WriteCreateProduct(string input,Data data)
        {
            using(StreamWriter sw = File.CreateText(input))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }
        }
        public static void SeeProductInCart(Data data)
        {
            Console.WriteLine($"Name\t\t\tCount\t\tMoneyInOneProduct\tSum");
            foreach(var item in data.Cart)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
        public static void RemoveNameProduct(string input,Data data)
        {
            Console.WriteLine("Enter Name Product Remove: ");
            string name = Console.ReadLine().ToUpper();
            int pos = data.IndexNameProduct(name);
            data.Cart.RemoveAt(pos);
            using(StreamWriter sw = File.CreateText(input))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }
        }
        public static void Pay(string input,string output,Data data)
        {
            var newdata = new NewData()
            {
                Cart = new List<MProduct>()
            };
            foreach(var item in data.Cart)
            {
                newdata.Cart.Add(new MProduct()
                {
                    Name = item.Name,
                    Count = item.Count,
                    Money = item.Money
                });
            }
            using (StreamWriter sw = File.CreateText(output))
            {
                var result = JsonConvert.SerializeObject(newdata);
                sw.WriteLine(result);
            }
            data.Cart.Clear();
            using(StreamWriter sw = File.CreateText(input))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }
        }
    }
}
