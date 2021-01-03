using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Максимальне значення: {LongRange.Max}");
            Console.WriteLine($"Мінімальне значення: {(long)LongRange.Min}");
        }
    }
}
