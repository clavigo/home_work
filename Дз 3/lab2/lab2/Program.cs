using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть радіус кола: ");
            var radius = float.Parse(Console.ReadLine());

            Console.WriteLine($"Площа кола: {Circle.Area(radius)} \nДовжина кола: {Circle.Length(radius)}");
        }
    }
}
