using System;
using System.Collections.Generic;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person() {Name="Абдул", Age = 23, PhoneNumbers = new List<string>{"+380673567834","+380680469238", "+380985268965" } },
                new Person() {Name="Пол", Age = 65,PhoneNumbers = new List<string>{"+38067458713","+380660947395", "+380560945990" } },
                new Person() {Name="Геннадiй", Age = 56,PhoneNumbers = new List<string>{"+380347699435","+380542344578", "+380997492000" } },
                new Person() {Name="Олег", Age = 35,PhoneNumbers = new List<string>{"+380892342490","+380752366972", "+380236733544" } },
                new Person() {Name="Рiкардо", Age = 26,PhoneNumbers = new List<string>{"+380693587656","+380615788788", "+380452355233" } },
                new Person() {Name="Дмитрiй", Age = 8,PhoneNumbers = new List<string>{"+38062238890","+380329029388", "+380935890244" } }
            };

            persons.AddRange(new List<Person> 
            {
                new Person(){Name="Галина", Age = 44, PhoneNumbers = new List<string>{"+380559836723","+380653456655", "+380532554344" } },
                new Person(){Name="Iнесса", Age = 37, PhoneNumbers = new List<string>{"+380584533646","+380667828834", "+38033452565" } }
            });

            foreach (Person ThePerson in persons)
            {
                Console.WriteLine($"Номер телефону {ThePerson.Name}: ");
                foreach(var number in ThePerson.PhoneNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadKey();
        }
    }
}
