using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a;

            Console.Write("Enter strings: ");
            a = Console.ReadLine().Split( );
            a = Console.ReadLine().Split( );

            Array.Sort(a, StringComparer.InvariantCultureIgnoreCase);

            for (int i = 0; i < a.Length; i++)
            {
                if (i != a.Length - 1)
                {
                    Console.Write($"{a[i]}, ");
                }
                else
                {
                    Console.WriteLine($"{a[i]}.");
                }
            }
        }
    }
}
