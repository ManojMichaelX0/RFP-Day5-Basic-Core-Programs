using System;

namespace Quoitent_And_Remainder
{
    public class Quoitent_And_Remainder
    {
        public void Quoitent_and_Remainder(double number)
        {
            double result1 = number % 2;
            double result2 = number / 2;
            Console.WriteLine($"Remainder of given number is : {result1}");
            Console.WriteLine($"Quoitent of given number is : {result2}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            double number = Convert.ToDouble(Console.ReadLine());
            Quoitent_And_Remainder qandr = new Quoitent_And_Remainder();
            qandr.Quoitent_and_Remainder(number);

        }
    }
}
