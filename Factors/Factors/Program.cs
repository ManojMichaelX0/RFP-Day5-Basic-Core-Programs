using System;

namespace Factors
{
    public class Factor
    {

        public void Factor_Of_Number(int number)
        {
            
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"Factors of Given Number are: {i}");

                }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            Factor f = new Factor();
            f.Factor_Of_Number(number);
        }
    }
}
