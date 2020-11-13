using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle:Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
        public Rectangle(int x, int y) : base(x, y)
        {

        }
    }
}
