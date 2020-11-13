using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle;
            string[] a;

            Console.Write("Ііедіть довжину довжину, ширину та координати Х та У: ");
            a = Console.ReadLine().Split(' ');

            rectangle = new Rectangle(double.Parse(a[0]), double.Parse(a[1]), double.Parse(a[2]), double.Parse(a[3]));

            Console.WriteLine($"Rectangle:\n\tWidth: {rectangle.width}\n\tHeight: {rectangle.height}\n\tPerimeter: {rectangle.Perimeter()}\n\tX: {rectangle.X}\n\tY: {rectangle.Y}");
        }
    }
}
