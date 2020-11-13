using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Figure:IDrawable
    {
        void IDrawable.Draw()
        {
            Console.WriteLine("Figure");
        }

        readonly int x;
        readonly int y;

        protected Figure(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
}
