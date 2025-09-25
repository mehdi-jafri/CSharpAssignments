using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    class Person4
    {
        public string Name;

        // Default constructor
        public Person4()
        {
            Name = "Unknown";
            Console.WriteLine("Default constructor called.");
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    internal class Default_Constructor
    {
        static void Main()
        {
            Person4 p = new Person4();  // Calls default constructor
            p.Display();
        }
    }
}
