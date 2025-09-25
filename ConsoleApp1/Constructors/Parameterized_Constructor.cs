using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    class Person2
    {
        public string Name;

        // Parameterized constructor
        public Person2(string name)
        {
            Name = name;
            Console.WriteLine("Parameterized constructor called.");
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class Parameterized_Constructor
    {
        static void Main()
        {
            Person2 p = new Person2("Alice");  // Calls parameterized constructor
            p.Display();
        }
    }
}
