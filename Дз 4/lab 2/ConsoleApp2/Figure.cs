using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class Figure
    {
        public abstract void Draw();

        readonly int x;
        readonly int y;

        protected Figure(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
}
