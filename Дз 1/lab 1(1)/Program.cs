using System;

namespace ConsoleApp13
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Введіть радіус кола: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * (radius* radius);
            Console.WriteLine("Площа: "+area);
        }
    }
}
