using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Square: Figure, IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Square");
        }
        public Square(int x, int y) : base(x, y)
        {

        }
    }
}
