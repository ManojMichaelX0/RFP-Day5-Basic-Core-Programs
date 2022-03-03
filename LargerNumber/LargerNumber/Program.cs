using System;

namespace LargerNumber
{
    public class Larger_Number
    {
        public void LargerNumber(int number1, int number2, int number3)
        {
            if ((number1 > number2) && (number1 > number3))
            {
                Console.WriteLine($"larger number is {number1}");
            }
            else if ((number2 > number3))
            {
                Console.WriteLine($"larger number is {number2}");
            }
            else
            {
                Console.WriteLine($"larger number is {number3}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numbers ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Larger_Number n = new Larger_Number();
            n.LargerNumber(number1,number2,number3);
        }
    }
}
