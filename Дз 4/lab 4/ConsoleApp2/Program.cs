using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 2);
            Square square = new Square(3, 4);

            static void DrawAll(params IDrawable[] array)
            {
                foreach (IDrawable drawable in array)
                {
                    drawable.Draw();
                }
            }

            IDrawable rectDrawable = (IDrawable)rectangle;
            IDrawable sqDrawable = (IDrawable)square;
            
            DrawAll(rectDrawable, sqDrawable);
        }
    }
}
