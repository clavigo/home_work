using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            string[] input;
            byte n;

            Console.Write("Введіть ім'я людини, прізвище та вік: ");
            input = Console.ReadLine().Split(' ');

            person = new Person(input[0], input[1], byte.Parse(input[2]));

            Console.Write("Введіть свій вік: ");
            n = byte.Parse(Console.ReadLine());

            Console.WriteLine(person.isOlderThan(n));
        }
    }
}
