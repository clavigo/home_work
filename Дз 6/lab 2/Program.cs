using System;
using System.Linq;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = a.Count(element => Prime(element));
            Console.WriteLine($"{result} простих чисел в масивi");

            Console.ReadKey();
        }
        public static bool Prime(int b)
        {
            var result = true;
            if(b > 1)
            {
                for(var i =2; i < b; i++)
                {
                    if (b % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
