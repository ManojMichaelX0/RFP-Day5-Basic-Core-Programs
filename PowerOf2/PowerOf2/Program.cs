using System;

namespace PowerOf2
{
    public class Power_Of_2
    {
        public void Power_Of_Two(int number)
        {
            int temp = number;
            int result = 1;
            while(number!=0)
            {
                result *= 2;
                number--;
            }
            Console.WriteLine($"Power of 2 ^ {temp} is : {result}");

        }
    }
    public class Program
    {
       public  static void Main(string[] args)
        {
            Power_Of_2 p2 = new Power_Of_2();
            Console.WriteLine("Enter the number ");
            int number = Convert.ToInt32(Console.ReadLine());
            p2.Power_Of_Two(number);
        }
    }
}
