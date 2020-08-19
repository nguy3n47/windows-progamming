using System;

namespace NextValidDate
{
    class Program
    {
        const int MAX_VALID_YR = 9999;
        const int MIN_VALID_YR = 1800;

        static void Main(string[] args)
        {
            Console.Write("Input Day: ");
            string day = Console.ReadLine();
            int d = int.Parse(day);

            Console.Write("Input Month: ");
            string month = Console.ReadLine();
            int m = int.Parse(month);

            Console.Write("Input Year: ");
            string year = Console.ReadLine();
            int y = int.Parse(year);

            if (isValidDate(d, m, y))
            {
                Console.WriteLine($"Date {d}/{m}/{y} is valid.");
                TheNextDay(ref d, ref m, ref y);
                Console.WriteLine($"Tomorrow: {d}/{m}/{y}.");

            }     
            else
                Console.WriteLine($"Date {d}/{m}/{y} is invalid.");

            // Returns true if  
            // given year is valid. 
            static bool isLeap(int year)
            {

                // Return true if year is a  
                // multiple of 4 and not  
                // multiple of 100. OR year 
                // is multiple of 400. 
                return (((year % 4 == 0) &&
                         (year % 100 != 0)) ||
                         (year % 400 == 0));
            }

            // Returns true if given 
            // year is valid or not. 
            static bool isValidDate(int d,
                                    int m,
                                    int y)
            {

                // If year, month and day  
                // are not in given range 
                if (y > MAX_VALID_YR ||
                    y < MIN_VALID_YR)
                    return false;
                if (m < 1 || m > 12)
                    return false;
                if (d < 1 || d > 31)
                    return false;

                // Handle February month  
                // with leap year 
                if (m == 2)
                {
                    if (isLeap(y))
                        return (d <= 29);
                    else
                        return (d <= 28);
                }

                // Months of April, June,  
                // Sept and Nov must have  
                // number of days less than 
                // or equal to 30. 
                if (m == 4 || m == 6 ||
                    m == 9 || m == 11)
                    return (d <= 30);

                return true;
            }

            static void TheNextDay(ref int d, ref int m, ref int y)
            {
                d++;
                int numberOfDays = DateTime.DaysInMonth(y, m);
                if (d > numberOfDays)
                {
                    d = 1;
                    m++;
                    if (m > 12)
                    {
                        m = 1;
                        y++;
                    }
                }
            }
        }
    }
}
