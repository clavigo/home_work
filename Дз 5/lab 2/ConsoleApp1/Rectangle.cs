using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Rectangle
    {
        public double width { get; set; }
        public double height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(double width1, double height1, double x1, double y1)
        {
            width = width1;
            height = height1;
            X = x1;
            Y = y1;
        }
        public double Perimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
