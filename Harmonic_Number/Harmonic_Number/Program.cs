using System;

namespace Harmonic_Number
{
    public class Harmonic
    {
        public void HarmonicNum(int number)
        {
            double result = 0;
            for( int i = 1; i <= number; i++ )
            {
                result = (result + 1)/ i;
            }
            Console.WriteLine($"Harmonic Number of given number is :{result}");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number :");
            Harmonic h = new Harmonic();
            int number =Convert.ToInt32(Console.ReadLine());
            h.HarmonicNum(number);
        }
    }
}
