using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Circle
    {
        static float pi = 3.141592f;

        public static float Length(float radius)
        {
            return 2 * pi * radius;
        }

        public static float Area(float radius)
        {
            return radius * radius * pi;
        }
    }
}
