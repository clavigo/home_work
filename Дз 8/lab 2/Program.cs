using System;
using System.IO;
using System.Collections;
using System.Linq;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть ім'я або частину назви файлу, який потрібно знайти: "); 
            var fileName = Console.ReadLine();

            Console.WriteLine("Введіть каталог, в якому потрібно шукати файл: "); //C:\Users\Admin\Desktop\ConsoleApp1
            var directoryName = Console.ReadLine();

            var directory = new DirectoryInfo(directoryName);

            if (Search(directory, fileName) == 1)
            {
                Console.WriteLine("У цьому каталозі файл з таким ім'ям не існує.");
            }
            Console.ReadKey();
        }
        static int Search(DirectoryInfo directoryName, string fileName)
        {
            foreach (var file in directoryName.GetFiles($"*{fileName}*.txt"))
            {
                Console.WriteLine("Файл знайдено: ");
                Console.WriteLine($"{file}");
                return 0;
            }
            return 1;
        }
    }
}
