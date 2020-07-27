using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace BtJson_3
{
    class Program
    {  
        static void Main(string[] args)
        {
            var path = @"D:\C0520G1\Module_2\FileDemo\BtJson_3\Data";
            var input = "Order.json";
            var output = "Bill";
            DateTime time = DateTime.Now;
            string datatime = time.ToString("dd_MM_yyyy_hh_mm");
            var data = CreateTable($@"{path}\{input}");
            WriteCreateTable($@"{path}\{input}", data);
            var result = ReadFile($@"{path}\{input}");
            WriteFilePay($@"{path}\{output}_{datatime}.json", result, $@"{path}\{input}");
        }
        public static Data CreateTable(string input)
        {
            var result = new Data();
            bool check_table = true;
            bool check_name = true;
            using(StreamReader sr = File.OpenText(input))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
                Console.Write("Enter Table: ");
                int table = Int32.Parse(Console.ReadLine());
                Console.Write("Enter NameProduct: ");
                string name = Console.ReadLine();
                Console.Write("Enter Count: ");
                int count = Int32.Parse(Console.ReadLine());
                Console.Write("Enter Money: ");
                int money = Int32.Parse(Console.ReadLine());
                foreach(var item in result.MCoffee)
                {
                    if(item.Table == table)
                    {
                        check_table = false;
                        for (int i = 0; i < item.items.Count; i++)
                        {                        
                            Item nameProduct = item.items[i];
                            if (nameProduct.name == name)
                            {
                                check_name = false;
                                nameProduct.Count += count;
                            }                           
                        }
                        if (check_name)
                        {
                            item.items.Add(new Item()
                            {
                                name = name,
                                Count = count,
                                money = money
                            });
                        }
                    }
                }
                if (check_table)
                {
                    var item = new List<Item>();
                    item.Add(new Item()
                    {
                        name = name,
                        Count = count,
                        money = money
                    });
                    result.MCoffee.Add(new Coffee()
                    {
                        Table = table,
                        items = item
                    });
                }
            }
            return result;
        }
        public static void WriteCreateTable(string input,Data data)
        {
            using (StreamWriter sw = File.CreateText(input))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);

            }
        }

        public static void WriteFile(string input, object data)
        {
            using(StreamWriter sw = File.CreateText(input))
            {
                var newdata = JsonConvert.SerializeObject(data);
                sw.WriteLine(newdata);
            }

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
        public static void WriteFilePay(string output, Data data,string input)
        {
            bool isCheck = true;
            var newData = new NewData()
            {
                MCoffee = new List<NewCoffee>()
            };
            Console.Write("Enter Table Pay: ");
            int table = Int32.Parse(Console.ReadLine());
            var pos = data.checkTable(table);
            for(int i = 0; i < data.MCoffee.Count; i++)
            {
                if(pos == i)
                {
                    isCheck = false;
                    newData.MCoffee.Add(new NewCoffee()
                    {
                        Table = data.MCoffee[pos].Table,
                        PAY = true,
                        items = data.MCoffee[pos].items
                    });
                }
            } 
            if (isCheck)
            {
                Console.WriteLine("Invalid table");
            }

            using(StreamWriter sw = File.CreateText(output))
            {
                var dataa = JsonConvert.SerializeObject(newData);
                sw.WriteLine(dataa);
            }

            data.MCoffee.RemoveAt(pos);
            using (StreamWriter sw = File.CreateText(input))
            {
                var dataa = JsonConvert.SerializeObject(data);
                sw.WriteLine(dataa);
            }

        }
    }
}
