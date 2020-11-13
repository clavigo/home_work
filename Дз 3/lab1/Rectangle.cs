using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Rectangle
    {
        private Vertices LeftTopVertice;
        private Vertices RightBottomVertice;

        
        private double verticalEdge;
        private double horizontalEdge;

        public Rectangle(Vertices leftTop, Vertices rightBottom)
        {
            this.LeftTopVertice = leftTop;
            this.RightBottomVertice = rightBottom;

            verticalEdge = leftTop.Y - rightBottom.Y;
            horizontalEdge = rightBottom.X - leftTop.X;
        }

        public double Area()
        {
            return verticalEdge * horizontalEdge;
        }

        public double Perimeter()
        {
            return verticalEdge * 2 + horizontalEdge * 2;
        }
    }
}
