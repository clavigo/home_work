using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторону куба: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double volume = side * side * side;
            Console.WriteLine("Об`єм: " + volume);
        }
    }
}
