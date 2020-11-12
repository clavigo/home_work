using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            Console.Write("Введіть число: ");
            input = float.Parse(Console.ReadLine());
            Console.WriteLine($"Integral part: {Math.Truncate(input)}. Rounded: {Math.Round(input)}.");     
        }
    }
}
