using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] surnames;
            Console.Write("Введіть прізвища студентів: ");
            surnames = Console.ReadLine().Split(',') ;

            if (surnames[0].Length == surnames[1].Length)
            {
                Console.WriteLine("Прізвища однакової довжини");
            }
            else
            {
                Console.WriteLine("Прізвища різної довжини");
            }

            if (surnames[0][0] == surnames[1][0])
            {
                Console.WriteLine("Перші букви прізвищ співпадають");
            }
            else 
            {
                Console.WriteLine("Перші букви прізвищ не співпадають");
            }

            if (surnames[0][surnames[0].Length - 1] == surnames[1][surnames[1].Length - 1])
            {
                Console.WriteLine("Останні букви прізвищ співпадають");
            }
            else
            {
                Console.WriteLine("Останні букви прізвищ не співпадають");
            }
        }
    }
}
