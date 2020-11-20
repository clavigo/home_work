using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rectangle : Figure
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
