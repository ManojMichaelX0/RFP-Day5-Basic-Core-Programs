using System;

namespace Vowel_Or_Consonant
{
    public class VowelOrConsonant
    {
        public void Vowel_OR_Consonant(char letter)
        {
            if (letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' || letter == 'u' || letter == 'U')
            {
                Console.WriteLine($"Given letter : {letter} is Vowel");
            }
            else
            {
                Console.WriteLine($"Given letter : {letter} is Consonant");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Char Value");
            char letter = Convert.ToChar(Console.ReadLine());
            VowelOrConsonant voc = new VowelOrConsonant();
            voc.Vowel_OR_Consonant(letter);
        }
    }
}
