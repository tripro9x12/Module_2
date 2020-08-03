using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Cau3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\C0520G1\Module_2\OnTap_Module2\Cau3\Data";
            Directory.CreateDirectory(path);
            string database = "database.json";
            string output = "odersCode.json";
            string dateTime = DateTime.Now.ToString("ddMMyyy_HHmmss");
            bool check = false;
            Data data = new Data();


            int choice = 1;
            while(choice != 17)
            {
                Console.WriteLine("1.ReadFileJSON");
                Console.WriteLine("2.checkSighInAdmin");
                Console.WriteLine("3.MemberManagement");
                Console.WriteLine("4.WriteFileOdersToJSON");
                Console.WriteLine("5.WriteFileMemberToJSON");
                Console.WriteLine("6.ChangePassword");
                Console.WriteLine("7.CreateEmail");
                Console.WriteLine("8.CreateOder");
                Console.WriteLine("9.ShowOders");
                Console.WriteLine("10.SearchOdersCode");
                Console.WriteLine("11.SearchNameCustomerOrAddress");
                Console.WriteLine("12.EditStatus");
                Console.WriteLine("13.UpdateByOdersCode");
                Console.WriteLine("14.ShowAllProduct");
                Console.WriteLine("15.SearchProductCode_or_Name");
                Console.WriteLine("16.WriteFilePay");
                Console.WriteLine("17.Exit");

                Console.WriteLine("Moi ban chon:...");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        data = ReadFileJSON($@"{path}\{database}");
                        break;
                    case 2:
                        checkSighInAdmin(ref check, data);
                        break;
                    case 3:
                        if (check)
                        {
                            MemberManagement(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 4:
                        if (check)
                        {
                            WriteFileOdersToJSON(data,$@"{path}\{database}");
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 5:
                        if (check)
                        {
                            WriteFileMemberToJSON(data, $@"{path}\{database}");
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 6:
                        if (check)
                        {
                            ChangePassword(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 7:
                        if (check)
                        {
                            CreateEmail(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 8:
                        if (check)
                        {
                            CreateOder(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 9:
                        if (check)
                        {
                            ShowOders(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 10:
                        if (check)
                        {
                            SearchOdersCode(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 11:
                        if (check)
                        {
                            SearchNameCustomerOrAddress(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 12:
                        if (check)
                        {
                            EditStatus(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 13:
                        if (check)
                        {
                            UpdateByOdersCode(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 14:
                        if (check)
                        {
                            ShowAllProduct(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 15:
                        if (check)
                        {
                            SearchProductCode_or_Name(data);
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 16:
                        if (check)
                        {
                            WriteFilePay(data,$@"{path}\{dateTime}_{output}" ,$@"{path}\{database}");
                        }
                        else
                        {
                            Console.WriteLine("Ban phai dang nhap truoc da...");
                        }
                        break;
                    case 17:
                        break;
                    default:
                        Console.WriteLine("Chon sai, moi chon lai......");
                        break;
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }
        public static Data ReadFileJSON(string path)
        {
            var result = new Data();
            using(StreamReader sr = File.OpenText(path))
            {
                var data = sr.ReadToEnd();
                result = JsonConvert.DeserializeObject<Data>(data);
            }
            return result;
        }
        public static void checkSighInAdmin(ref bool check,Data data)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine().ToUpper();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine().ToUpper();
            if(data.emailOfManagement != email)
            {
                Console.WriteLine("Email khong ton tai...");
            }
            else
            {
                if(data.password != password)
                {
                    Console.WriteLine("sai password...");
                }
                else
                {
                    Console.WriteLine("dang nhap thanh cong...");
                    check = true;
                }
            }
        }
        public static void MemberManagement(Data data)
        {
            Console.WriteLine($"Name\tEmail\tPassword\tPhone\tAddress");
            foreach(var item in data.member)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void WriteFileOdersToJSON(Data data,string path)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }
        }
        public static void WriteFileMemberToJSON(Data data, string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }
        }
        public static void ChangePassword(Data data)
        {
            bool checkEmail = true;
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            foreach(var item in data.member)
            {
                if(item.email.ToUpper() == email.ToUpper()){
                    checkEmail = false;
                    if(item.password == password)
                    {
                        Console.Write("Enter New Password: ");
                        item.password = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ban phai dang nhap truoc da...");
                    }
                }
            }
            if (checkEmail)
            {
                Console.WriteLine("Email khong ton tai...");
            }
        }
        public static Data CreateEmail(Data data)
        {
            bool checkEmail = true;
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            foreach (var item in data.member)
            {
                if(item.email == email)
                {
                    checkEmail = false;
                }
            }
            if (checkEmail)
            {
                data.member.Add(new MemberManagement()
                {
                    name = name,
                    email = email,
                    password = password,
                    phone = phone,
                    address = address
                });
            }
            return data;
        }

        public static Data CreateOder(Data data)
        {
            bool checkodersCode = true;
            bool checkCode = true;
            Console.Write("Enter odersCode: ");
            string odersCode = Console.ReadLine();
            Console.Write("Enter nameCustomer: ");
            string nameCustomer = Console.ReadLine();
            Console.Write("Enter address: ");
            string address = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter code: ");
            string codeProduct = Console.ReadLine();
            Console.Write("Enter count: ");
            int count = Int32.Parse(Console.ReadLine());
            foreach (var item in data.oders)
            {
                if(item.odersCode.ToUpper() == odersCode.ToUpper())
                {
                    checkodersCode = false;
                    
                    foreach(var items in item.product)
                    {
                        if(items.code.ToUpper() == codeProduct.ToUpper())
                        {
                            checkCode = false;
                            items.count += count;
                        }
                    }
                    if (checkCode)
                    {
                        foreach(var itemproductall in data.ProductAll)
                        {
                            if(codeProduct.ToUpper() == itemproductall.code.ToUpper())
                            {
                                item.product.Add(new OdersProduct()
                                {
                                    code = codeProduct,
                                    name = itemproductall.name,
                                    count = count,
                                    price = itemproductall.priceOut
                                });
                                itemproductall.count -= count;
                            }
                        }
                    }
                }
            }
            if (checkodersCode)
            {
                List<OdersProduct> product = new List<OdersProduct>();
                foreach(var item in data.ProductAll)
                {
                    if(codeProduct.ToUpper() == item.code.ToUpper())
                    {
                        product.Add(new OdersProduct()
                        {
                            code = codeProduct,
                            name = item.name,
                            count = count,
                            price = item.priceOut
                        });
                        item.count -= count;
                    }
                    
                }
                data.oders.Add(new OdersManagement()
                {
                    odersCode = odersCode,
                    nameCustomer = nameCustomer,
                    address = address,
                    phone = phone,
                    product = product
                });
            }
            return data;
        }
        public static void ShowOders(Data data)
        {
            Console.WriteLine("odersCode\tnameCustomer\taddress\tphone\tstatus\tdateTime\t");
            foreach(var item in data.oders)
            {
                Console.Write(item.ToString());
                Console.Write("code\tname\tcount\tprice\tsumPrice");
                foreach(var items in item.product)
                {
                    Console.WriteLine($"\t\t\t\t\t\t\t{items.code}\t{items.name}\t{items.count}\t{items.price}\t{items.sumPrice}");
                }
            }
        }
        public static void SearchOdersCode(Data data)
        {
            Console.WriteLine("Enter odersCode: ");
            string odersCode = Console.ReadLine();
            bool check = true;
            for(int i = 0; i < data.oders.Count; i++)
            {
                if (odersCode.ToUpper() == data.oders[i].odersCode.ToUpper())
                {
                    check = false;
                    Console.WriteLine(data.oders[i].ToString());
                }
            }
            if (check)
            {
                Console.WriteLine("Khong tim thay ");
            }
        }
        public static void SearchNameCustomerOrAddress(Data data)
        {
            Console.WriteLine("Enter nameCustomer: ");
            string nameCustomer = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();
            bool check = true;
            for (int i = 0; i < data.oders.Count; i++)
            {
                if (nameCustomer.ToUpper() == data.oders[i].nameCustomer.ToUpper() || address.ToUpper() == data.oders[i].address.ToUpper())
                {
                    check = false;
                    Console.WriteLine(data.oders[i].ToString());
                }
            }
            if (check)
            {
                Console.WriteLine("Khong tim thay ");
            }
        }
        public static Data EditStatus(Data data)
        {
            Console.Write("Enter odersCode: ");
            string odersCode = Console.ReadLine();
            Console.Write("Enter EditStatus: ");
            string status = Console.ReadLine();
            foreach(var item in data.oders)
            {
                if(odersCode.ToUpper() == item.odersCode.ToUpper())
                {              
                    item.status = status;
                }
            }
            return data;
        }
        public static Data UpdateByOdersCode(Data data)
        {
            bool checkStatus = true;
            foreach(var item in data.oders)
            {
                if(item.status != "accept the application")
                {
                    checkStatus = false;
                }
            }
            if (checkStatus)
            {
                data.oders.Sort(new SortByOdersCode<OdersManagement>());
            }
            return data;
        }
        public static void ShowAllProduct(Data data)
        {
            Console.WriteLine("code\tname\tcount\tpriceIn\tpriceOut\tsumPriceIn\tsumPriceOut");
            foreach (var item in data.ProductAll)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void SearchProductCode_or_Name(Data data)
        {
            Console.Write("Enter code: ");
            string code = Console.ReadLine();
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            foreach(var item in data.ProductAll)
            {
                if(code.ToUpper() == item.code.ToUpper() || name.ToUpper() == item.name.ToUpper())
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        public static void WriteFilePay(Data data,string output,string input)
        {
            int pos = data.IndexStatus();
            if (pos >= 0)
            {
                using (StreamWriter sw = File.CreateText(output))
                {
                    var result = JsonConvert.SerializeObject(data.oders[pos]);
                    sw.WriteLine(result);
                }
            }
            data.oders.RemoveAt(pos);
            using(StreamWriter sw = File.CreateText(input))
            {
                var result = JsonConvert.SerializeObject(data);
                sw.WriteLine(result);
            }

        }
       
    }
    class SortByOdersCode<T> : IComparer<OdersManagement>
    {
        public int Compare([AllowNull] OdersManagement x, [AllowNull] OdersManagement y)
        {
            return string.Compare(x.odersCode, y.odersCode);
        }
    }
}