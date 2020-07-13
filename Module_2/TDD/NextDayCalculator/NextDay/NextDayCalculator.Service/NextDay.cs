using System;
using System.Collections.Generic;
using System.Text;

namespace NextDayCalculator.Service
{
    public class NextDay
    {
        public int Day;
        public int Month;
        public int Year;
        public NextDay()
        {

        }
        public NextDay(int date, int month, int year)
        {
            this.Day = date;
            this.Month = month;
            this.Year = year;
        }
        public int DATE
        {
            get => this.Day;
            set => this.Day = value;
        }
        public int MONTH
        {
            get => this.Month;
            set => this.Month= value;
        }
        public int YEAR
        {
            get => this.Year;
            set => this.Year = value;
        }
        //internal void SetMonth1_3_5_7_8_10(int day, int month,int year)
        //{
        //    if (day > 0 && day <= 31)
        //    {
        //        if (day < 31)
        //        {
        //            day = day + 1;
        //        }
        //        else
        //        {
        //            day = 1;
        //            month = month + 1;
        //        }
        //    }
           
        //}
        //internal void SetMonth12(int day, int month,int year)
        //{
        //    if (day > 0 && day < 31)
        //    {
        //        day = day + 1;
        //    }
        //    else if (day == 31)
        //    {
        //        day = 1;
        //        month = 1;
        //        year = year + 1;
        //    }
        //}
        //internal void SetMonth2(int day, int month,int year)
        //{
        //    if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
        //    {
        //        if (day > 0 && day <= 29)
        //        {
        //            if (day < 29)
        //            {
        //                day += 1;
        //            }
        //            else
        //            {
        //                day = 1;
        //                month += 1;
        //            }
        //        }

        //    }
        //    else
        //    {
        //        if (day > 0 && day <= 28)
        //        {
        //            if (day < 28)
        //            {
        //                day += 1;
        //            }
        //            else
        //            {
        //                day = 1;
        //                month += 1;
        //            }
        //        }             
                
        //    }
        //}
        //internal void SetMonth4_6_9_11(int day, int month,int year)
        //{
        //    if (day > 0 && day <= 30)
        //    {
        //        if (day < 30)
        //        {
        //            day = day + 1;
        //        }
        //        else
        //        {
        //            day = 1;
        //            month = month + 1;
        //        }
                
        //    }

        //}
        public string GetDateTime(int day, int month, int year)
        {
            
            if(month > 0 && month <= 12 && day>0 && day<=31 && year > 0)
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                        if (day > 0 && day <= 31)
                        {
                            if (day < 31)
                            {
                                day = day + 1;
                            }
                            else
                            {
                                day = 1;
                                month = month + 1;
                            }
                        }
                        return $"{day}/{month}/{year}";

                    case 12:
                        if (day > 0 && day < 31)
                        {
                            day = day + 1;
                        }
                        else if (day == 31)
                        {
                            day = 1;
                            month = 1;
                            year = year + 1;
                        }
                        return $"{day}/{month}/{year}";

                    case 2:

                        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        {
                            if (day > 0 && day <= 29)
                            {
                                if (day < 29)
                                {
                                    day += 1;
                                }
                                else
                                {
                                    day = 1;
                                    month += 1;
                                }
                            }

                        }
                        else
                        {
                            if (day > 0 && day <= 28)
                            {
                                if (day < 28)
                                {
                                    day += 1;
                                }
                                else
                                {
                                    day = 1;
                                    month += 1;
                                }
                            }

                        }
                        return $"{day}/{month}/{year}";

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (day > 0 && day <= 30)
                        {
                            if (day < 30)
                            {
                                day = day + 1;
                            }
                            else
                            {
                                day = 1;
                                month = month + 1;
                            }

                        }
                        return $"{day}/{month}/{year}";
                    default:
                        break;

                } 
            }
            return "Nhập sai";
        }
    }
}
