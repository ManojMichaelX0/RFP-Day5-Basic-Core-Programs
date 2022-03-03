using System;

namespace FlipCoin
{
    public class FlipCoinprogram
    {
        int headcount = 0;
        int tailcount = 0;
        public void FlipCoinMethod(int input)
        {
            int temp = input;
            Random r = new Random();
            while (input != 0)
            {
                
                double random = r.NextDouble();
                if (random <= 0.5)
                {
                    tailcount++;
                }
                else
                {
                    headcount++;
                }
                input--;

            }
            Console.WriteLine((headcount * 101)/temp);
            Console.WriteLine((tailcount * 101)/temp);

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int number=Convert.ToInt32(Console.ReadLine());
            FlipCoinprogram f = new FlipCoinprogram();
            f.FlipCoinMethod(number);
        }

    }
}
   