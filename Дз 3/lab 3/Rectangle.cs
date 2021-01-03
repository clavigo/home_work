using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class Rectangle
    {
        private Vertices LeftTopVertice;
        private Vertices RightBottomVertice;

        public double Area { get; set; }
        public double Perimetr { get; set; }

        private double verticalEdge;
        private double horizontalEdge;

        public Rectangle(Vertices leftTop, Vertices rightBottom)
        {
            this.LeftTopVertice = leftTop;
            this.RightBottomVertice = rightBottom;

            verticalEdge = leftTop.Y - rightBottom.Y;
            horizontalEdge = rightBottom.X - leftTop.X;

            Area = verticalEdge * horizontalEdge;
            Perimetr = verticalEdge * 2 + horizontalEdge * 2;
        }
    }
}
