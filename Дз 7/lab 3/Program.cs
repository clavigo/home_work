using System;
using System.Collections.Generic;

namespace lab_3
{
    class Program
    {
        
        public static List<string> strings;
        static void Main(string[] args)
        {
            strings = new List<string>(150);
            Random rand = new Random();
            string a;

            for (int i = 0; i < 150; i++)
            {
                a = "";
                for (int j = 0; j < 4; j++)
                {
                    a += (char)((rand.Next() % 26) + 65);
                }
                strings.Add(a);
            }

            Console.WriteLine("Кількість елементів до проведення трансформацій: {0}", strings.Count);

            while (strings.FindIndex(l => l[0] == 'Z') != -1)
            {
                strings.RemoveAt(strings.FindIndex(l => l[0] == 'Z'));
            }

            Console.WriteLine("Кількість елементів після проведених трансформацій: {0}", strings.Count);

            strings.Sort();
            for (int i = 0; i < strings.Count / 2; i++)
            {
                a = strings[i];
                strings[i] = strings[strings.Count - 1 - i];
                strings[strings.Count - 1 - i] = a;
            }

            while (true)
            {
                Console.WriteLine("\nВведіть номер сторінку: ");
                if (!int.TryParse(Console.ReadLine(), out int pageNumber))
                    break;
                pageNumber--;
                DisplayPage(pageNumber);
            }

            return;
        }
        public static void DisplayPage(int NumOfPage)
        {
            if (NumOfPage * 5 > strings.Count|| NumOfPage < 0)
            {
                Console.Write("Введіть іншу сторінку");
                return;
            }
            for (int i = NumOfPage * 5; !(i >= (NumOfPage * 5) + 5 || i >= strings.Count); i++)
            {
                Console.Write(strings[i] + "  ");
            }

            return;
        }
    }
}
