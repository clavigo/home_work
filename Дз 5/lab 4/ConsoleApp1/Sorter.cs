using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Sorter
    {
        public static void SortColors(this Colors color)
        {          
            int[] values = (int[])Enum.GetValues(color.GetType());

            Array.Sort(values);

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("",(Colors)values[i], values[i]);
            }
        }
    }
}
