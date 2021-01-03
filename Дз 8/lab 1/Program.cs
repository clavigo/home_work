using System;
using System.IO;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            
            Console.WriteLine("Введiть назву директорiї"); //D:\games\SnowRunner\en_us\Sources\Bin
            a = Console.ReadLine();

            if (Directory.Exists(a))
            {
                Console.WriteLine("Пiддерикторiї:");
                string[] dirs = Directory.GetDirectories(a);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }              
                Console.WriteLine("\nФайли:");
                string[] files = Directory.GetFiles(a);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine("Директорiї з такою назвою не iснує");
            }
            Console.ReadKey();
        }
    }
}
