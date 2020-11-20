using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    struct Person
    {
        string Firstname, Lastname;
        byte Age;

        public Person(string firstname, string lastname, byte age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string isOlderThan(byte n)
        {
            if (Age > n)
            {
                return $"{Age}>{n}. {Firstname} {Lastname} старший за Вас.";
            }
            else if (Age < n)
            {
                return $"{Age}<{n}. {Firstname} {Lastname} молодший за Вас.";
            }
            else
            {
                return $"{Age}={n}. {Firstname} {Lastname} ваш одноліток.";
            }
        }
    }
}
