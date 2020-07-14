using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTranslate.Service
{

    public class FizzBuzz
    {
        private const int num_1 = 5;
        private const int num_2 = 3;

        private int number { get; set; }
        public FizzBuzz() { }
        public FizzBuzz(int number)
        {
            this.number = number;
        }
        public string Fizz_Buzz(int num)
        {
            if(num%num_1 == 0 && num % num_2 == 0)
            {
                return "FizzBuzz";
            }
            else
            {
                if(num%num_1 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return "Fizz";
                }
            }
           
        }
        public string CountTraslate(int num)
        {
            if(num>0 && num < 10)
            {
                switch (num)
                {
                    case 0:
                        return "mươi";
                    case 1:
                        return "một";
                    case 2:
                        return "hai";
                    case 3:
                        return "ba";
                    case 4:
                        return "bốn";
                    case 5:
                        return "năm";
                    case 6:
                        return "sáu";
                    case 7:
                        return "bảy ";
                    case 8:
                        return "tám ";
                    case 9:
                        return "chín";
                    case 10:
                        return "mười";
                    default:
                        return "";
                }
            }
            else
            {
                int number_1 = num / 10;
                int number_2 = num % 10;
                string count = "";
                switch (number_1)
                {
                    case 0:
                        count += "mươi ";
                        break;
                    case 1:
                        count += "một ";
                        break;
                    case 2:
                        count+= "hai ";
                        break;
                    case 3:
                        count+= "ba ";
                        break;
                    case 4:
                        count+= "bốn ";
                        break;
                    case 5:
                        count+= "năm ";
                        break;
                    case 6:
                        count+= "sáu ";
                        break;
                    case 7:
                        count+= "bảy ";
                        break;
                    case 8:
                        count+= "tám ";
                        break;
                    case 9:
                        count+= "chín ";
                        break;
                    case 10:
                        count+= "mười ";
                        break;
                    default:
                        break;
                }
                switch (number_2)
                {
                    case 0:
                        count += "mươi";
                        break;
                    case 1:
                        count += "một";
                        break;
                    case 2:
                        count += "hai";
                        break;
                    case 3:
                        count += "ba";
                        break;
                    case 4:
                        count += "bốn";
                        break;
                    case 5:
                        count += "năm";
                        break;
                    case 6:
                        count += "sáu";
                        break;
                    case 7:
                        count += "bảy ";
                        break;
                    case 8:
                        count += "tám ";
                        break;
                    case 9:
                        count += "chín";
                        break;
                    case 10:
                        count += "mười";
                        break;
                
                }
                return count;
            }
  
        }

        public string Translate(int number)
        {
            if(number>0 && number < 100)
            {
                if(number%num_1 ==0 || number % num_2 == 0)
                {
                    return this.Fizz_Buzz(number);
                }
                else
                {
                    return this.CountTraslate(number);
                }
            }
            else
            {
                return "";
            }
        }
    }
}
