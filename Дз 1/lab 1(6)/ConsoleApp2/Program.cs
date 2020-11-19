using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.Write("Ведіть число: ");
            a = float.Parse(Console.ReadLine());
            b = (float)Math.Sqrt(Math.Ceiling(a));
            Console.WriteLine($"Результат: {b}");
        }
    }
}
