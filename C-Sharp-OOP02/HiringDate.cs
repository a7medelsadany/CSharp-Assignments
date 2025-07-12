using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP02
{
    internal class HiringDate
    {
        public int day;
        public int month { get; set; }
        public int year { get; set; }

       public int Day
        {
            get
            {
                return day;
            }
            set
            {
                if (value > 0 && value < 31)
                {
                    day = value;
                }
                else
                { 
                 Console.WriteLine("invalid day");
                }
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if(value>0 && value < 13)
                {
                    month = value;
                }
                else
                {
                Console.WriteLine("invalid month");
                }
            }
        }
        public HiringDate(int _day,int _month,int _year)
        {
            Day = _day;
            Month = _month;
            year = _year;
        }
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }
    }
}
