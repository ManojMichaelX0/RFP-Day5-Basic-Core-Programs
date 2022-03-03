using System;

namespace LeapYear
{
    public class LeapYear
    {
        public int year;

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYear ly = new LeapYear();

            if(((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine($"given year {year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"given year {year} is not a Leap Year");
            }
        }
    }
}
