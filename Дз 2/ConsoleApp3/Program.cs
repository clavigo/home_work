using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] surnames = new string[2];
            Console.Write("Enter surnames: ");
            surnames = Console.ReadLine().Split(',');
            surnames = Console.ReadLine().Split(',');

            if (surnames[0].Equals(surnames[1], StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Surnames are equal");
            }
            else
            {
                if (surnames[0].Length == surnames[1].Length)
                {
                    Console.WriteLine("Surnames are equal");
                }
                else if (surnames[0].Length > surnames[1].Length)
                {
                    Console.WriteLine("The first surname is longer than the second surname");
                }
                else
                {
                    Console.WriteLine("The second surname is longer than the first");
                }
            }


            if (surnames[0][0] == surnames[1][0] && surnames[0][surnames[0].Length - 1] == surnames[1][surnames[1].Length - 1])
            {
                Console.WriteLine("The first and the last letters in both strings are the same.");
            }
            else
            {
                Console.WriteLine("First or/and last characters in both strings are NOT the same.");
            }
        }
    }
}
