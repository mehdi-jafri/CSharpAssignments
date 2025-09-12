using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{

    class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        // Copy constructor
        public Person(Person p)
        {
            Name = p.Name;
            Console.WriteLine("Copy constructor called.");
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class Copy_Constructor
    {
        static void Main()
        {
            Person p1 = new Person("Bob");
            Person p2 = new Person(p1);  // Copy constructor copies p1's data
            p2.Display();
        }
    }
}
