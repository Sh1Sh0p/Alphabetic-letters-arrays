using System;
using System.Linq;

namespace AlphabeticLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many letters do you want?");
            
            var n = int.Parse(Console.ReadLine());
            
            char[] letters = new char[n];

            Console.WriteLine($"Type {n} letters from Alphabet...");

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Here are they alphabetic:");

            Array.Sort(letters);

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i]);
            }
        }
    }
}