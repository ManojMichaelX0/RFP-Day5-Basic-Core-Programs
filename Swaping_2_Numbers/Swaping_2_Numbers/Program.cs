using System;

namespace Swaping_2_Numbers
{
    public class SwapNumber
    {
        int temp = 0;
        public void Swapping(int number1, int number2)
        {
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"After Swapping number 1 : {number1} number 2 : {number2}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1 and number2");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Before Swapping number1 : {number1} number 2 : {number2}");
            SwapNumber swap = new SwapNumber();
            swap.Swapping(number1, number2);
        }
    }
}
