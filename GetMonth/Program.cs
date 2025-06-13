using System;
using System.Globalization;
using System.Threading;


namespace GetMonth
{
    class Program
    {
        static string GetMonthName(int Month)
        {
            string monthName;
            switch (Month)
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
                    monthName = "Invalid Month Number";
                    return null;
            }
            return monthName;
        }
        static void SayPeriod(int startMonth, int endMonth)
        {
            double Period =  startMonth-endMonth;
            if (Period < 0)
            {
                Period =Math.Abs(Period);
            }
            Console.WriteLine($"There is period from ({startMonth}){GetMonthName(startMonth)} to ({endMonth}){GetMonthName(endMonth)} :{Period} Months");
        }

        static void Main(string[] args)
        { 
            Console.Write("First month (1-12): ");
            int firstMonth = int.Parse(Console.ReadLine());

            Console.Write("Second month (1-12): ");
            int secondMonth = int.Parse(Console.ReadLine());

            SayPeriod(firstMonth, secondMonth);
        }
    }
}