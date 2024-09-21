using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section04_4_1
{
    public class YearMonth
    {


        public bool Is21Century
        {
            get
            {
                return 2001 < Year && Year < 2100;
            }
        }
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearMonth(int year = 2001, int month = 1)
        {
            this.Year = year;
            this.Month = month;
        }

        public YearMonth AddOneMonth()
        {
            if (Month == 12)
            {
                return new YearMonth(this.Year + 1, 1);
            }
            else
            {
                return new YearMonth(this.Year, this.Month + 1);
            }

            //var ym = new YearMonth(Year, Month); 내가 한거
            //if (Month == 12)
            //{
            //    ym.Year = Year++;
            //    ym.Month = 1;
            //}
            //else ym.Month++;
            //return ym;
        }

        public override string ToString()
        {
            return $"{Year}년 {Month}월";
        }
    }
}
