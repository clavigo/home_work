using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] word;

            Console.Write("Введіть слова які потрібно посортувавти: ");
            word = Console.ReadLine().Split();

            Array.Sort(word, StringComparer.InvariantCultureIgnoreCase);

            for (int i = 0; i < word.Length; i++)
            {
                if (i != word.Length - 1)
                {
                    Console.Write($"{word[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{word[i]}.");
                }
            }
        }
    }
}
