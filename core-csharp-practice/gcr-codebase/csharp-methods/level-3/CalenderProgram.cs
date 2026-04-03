using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Methods.level_3
{
    public class CalendarProgram
    {
        // Get month name using array
        static string GetMonthName(int month)
        {
            string[] months ={"January", "February", "March", "April","May", "June", "July", "August","September", "October", "November", "December"};
            return months[month - 1];
        }

        // Check leap year
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        // Get number of days in a month
        static int GetDaysInMonth(int month, int year)
        {
            int[] days ={31, 28, 31, 30, 31, 30,31, 31, 30, 31, 30, 31};

            if (month == 2 && IsLeapYear(year))
                return 29;

            return days[month - 1];
        }

        // Find which day the month starts on (Sunday = 0)
        static int GetStartingDay(int month, int year)
        {
            int day = 1;

            int adjustedYear = year - (14 - month) / 12;
            int temp = adjustedYear + adjustedYear / 4 - adjustedYear / 100 + adjustedYear / 400;
            int adjustedMonth = month + 12 * ((14 - month) / 12) - 2;

            int startingDay = (day + temp + (31 * adjustedMonth) / 12) % 7;

            return startingDay;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            string monthName = GetMonthName(month);
            int totalDays = GetDaysInMonth(month, year);
            int startDay = GetStartingDay(month, year);

            Console.WriteLine();
            Console.WriteLine("   " + monthName + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            // Print spaces before first date
            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }

            // Print all dates
            for (int date = 1; date <= totalDays; date++)
            {
                Console.Write($"{date,3} ");

                // Move to next line after Saturday
                if ((date + startDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
