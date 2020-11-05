using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Numerics;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.WriteLine("Введіть число: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Округлене число: " + Math.Round(a));
            Console.WriteLine("Ціла частина: " + Math.Floor(a));
            
        }
    }
}
