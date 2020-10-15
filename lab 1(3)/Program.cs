using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, m;

            Console.WriteLine("Введіть число n: ");
            n = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть число m: ");
            m = double.Parse(Console.ReadLine());

            if (n>1 & n<5 & m>1 & m<5 )
            {
      

                Console.WriteLine(Math.Pow(m, n));
            }
            else
            {
                Console.WriteLine("Числа повинні бути від 1 до 5.");
            }
            
            
        }
    }
}
