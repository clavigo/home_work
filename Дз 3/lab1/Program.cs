using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a;
            double[] aVertice = new double[4];

            Rectangle rectangle;
            Vertices LeftTopCoord;
            Vertices RightBottomCoord;

            Console.Write("Введіть координати точок: ");

            a = Console.ReadLine().Split(' ');

            for (int i = 0; i < 4; i++)
            {
                aVertice[i] = double.Parse(a[i]);
            }

            LeftTopCoord = new Vertices(aVertice[0], aVertice[1]);
            RightBottomCoord = new Vertices(aVertice[2], aVertice[3]);

            rectangle = new Rectangle(LeftTopCoord, RightBottomCoord);

            Console.WriteLine($"Площа прямокутника: {rectangle.Area()} \nПериметр прямокутника: {rectangle.Perimeter()}");
        }
    }
}
