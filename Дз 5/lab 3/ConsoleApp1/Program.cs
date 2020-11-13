using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введіть номер місяця: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Місяць: {(Month)a}");
        }
    }
}
