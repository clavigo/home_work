using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }

        readonly int x;
        readonly int y;

        public Figure(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
}
