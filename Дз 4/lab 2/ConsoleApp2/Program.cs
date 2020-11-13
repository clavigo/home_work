using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 2);
            Square square = new Square(3, 4);

            square.Draw();
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}
