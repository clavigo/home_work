using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Rectangle:Figure,IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Rectangle");
        }
        public Rectangle(int x, int y) : base(x, y)
        {

        }
    }
}
