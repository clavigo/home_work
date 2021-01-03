using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class SortColor
    {
        public static void Sorter(this Colors color)
        {
            
            var values = (int[])Enum.GetValues(typeof(Colors));

            Array.Sort(values);

            foreach (var t in values)
            {
                Console.WriteLine($"{(Colors)t} = {t}");
            }
        }
    }
}
