using System;

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть довжину та ширину масиву: ");

            var input = Console.ReadLine().Split(' ');
            var m = int.Parse(input[0]);
            var n = int.Parse(input[1]);
            var array = new int[m, n];

            for (var i = 0; i < m; i++)
            {
                Console.WriteLine($"Введіть елементи {i + 1} рядка:");
                input = Console.ReadLine().Split(' ');
                for (var j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(input[j]);
                }
            }

            var resultVector = new int[m];

            for (var i = 0; i < m; i++)
            {
                resultVector[i] = array[i, 0];
                for (var j = 0; j < n; j++)
                {
                    if (resultVector[i] < array[i, j]) resultVector[i] = array[i, j];
                }
            }

            Console.Write("Вектор складається з максимальних значень кожного рядка в масиві:\n( ");
            foreach (var element in resultVector)
            {
                Console.Write($"{element} ");
            }
            Console.Write(")");


        }
    }
}
