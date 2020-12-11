using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 1, 2, 3, 4, 5 };
            int[] QubeArray = Array;

            

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Вміст масиву[{0}]={1}", i, Array[i]);
            }
            Console.WriteLine("Після піднесення до куба: ");
            ChangeArray(QubeArray);
            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Вміст масиву[{0}]={1}", i, QubeArray[i]);
            }

            static void ChangeArray(int[] a, int b = 3)
            {
                for (var i = 0; i < 5; i++)
                {
                    a[i] = (int)Math.Pow(a[i],3);
                }
                
            }
            Console.ReadKey();
        }
    }
}
