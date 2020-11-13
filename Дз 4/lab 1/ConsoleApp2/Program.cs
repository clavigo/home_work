using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            square.draw();
            rectangle.draw();
        }
    }
}
