using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle;
            string[] a;

            Console.Write("Введіть ширину прямокутника, довжину та координати х, у: ");
            a = Console.ReadLine().Split(' ');

            rectangle = new Rectangle(double.Parse(a[0]), double.Parse(a[1]), double.Parse(a[2]), double.Parse(a[3]));

            Console.WriteLine($"Ширина: {rectangle.width}\nДовжина: {rectangle.height}\nПериметр: {rectangle.Perimeter()}\nКоординати: х = {rectangle.X}, у = {rectangle.Y}");
        }
    }
}
