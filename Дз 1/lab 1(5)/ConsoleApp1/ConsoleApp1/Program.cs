using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float input;
            float output;
            Console.Write("Введіть число: ");
            input = float.Parse(Console.ReadLine());
            output = input / 2;
            Console.WriteLine("Округлене число: {0:0.00}", Math.Round(output, 2));   
        }
    }
}
