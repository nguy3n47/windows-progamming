using System;

namespace Date
{
    class Program
    {
        static void NextDate(ref int day, ref int month, ref int year)
        {
            day++;
            int numberOfDays = DateTime.DaysInMonth(year, month);
            if (day > numberOfDays)
            {
                day = 1;
                month++;
                if (month > 12)
                {
                    month = 1;
                    year++;
                }
            }
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] max = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int year = rng.Next(0, 500) + 1900;
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                max[2] = 29;
            }    
            int month = rng.Next(1, 12);
            int day = rng.Next(1, max[month]);
            Console.WriteLine($"Date {day}/{month}/{year}.");
            NextDate(ref day, ref month, ref year);
            Tuple<int, int, int> Date = new Tuple<int, int, int>(day, month, year);
            Console.WriteLine($"Tomorrow: {Date.Item1}/{Date.Item2}/{Date.Item3}.");
        }
    }
}
