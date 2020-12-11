using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Введiть масив: ");

            var b = Console.ReadLine().Split(' ');
            var array = new int[b.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(b[i]);
            }
            var sym = Symmetric(array);
            Console.WriteLine(sym ? "Масив симетричний":"Масив не симетричний");

            Console.ReadKey();
        }
        static bool Symmetric(int[] a)
        {
            if (a.Length == 1 || a.Length == 0)
            {
                return true;
            }
            if (a[0] == a[^1])
            {
                return true;
            }

            return false;
        }
    }
}
