using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            float output;
            double a;

            Console.Write("Введіть число: ");
            input = float.Parse(Console.ReadLine());
            output = input / 2;
            a = Math.Round(output);
            Console.WriteLine("Округлене число: " + a);   
        }
    }
}
