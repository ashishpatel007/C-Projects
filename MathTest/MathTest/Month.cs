using System;
using System.Globalization;

namespace MathTest
{
    public class Month
    {
        public Month(int monthNumber)
        {
            MonthNumber = monthNumber;
        }

        public int MonthNumber { get; set; }

        public string GetMonthName()
        {
            /*
            string monthName = "";
            switch (MonthNumber)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Invalid Input";
                    break;

            }
            return monthName;
            */
            //Easier way to get the Month details
            DateTimeFormatInfo currentInfo = new DateTimeFormatInfo();
            return currentInfo.GetMonthName(MonthNumber);
        }

        public int GetMonthDays(){
            /*
            if (MonthNumber == 1 || MonthNumber == 3 || MonthNumber == 5 || MonthNumber == 7 || MonthNumber == 8 ||
               MonthNumber == 10 || MonthNumber == 12)
            {
                return 31;
            }
            else if (MonthNumber == 4 || MonthNumber == 6 || MonthNumber == 9 || MonthNumber == 11)
            {
                return 30;

            }
            else if (MonthNumber == 2)
                return 28;
            else
                return 0;
                */
            return DateTime.DaysInMonth(2016, MonthNumber); //gets the number of days in the month
        }

        public override string ToString()
        {
            return string.Format("Month of {0} has {1} days", GetMonthName(), GetMonthDays());
        }
    }
}
