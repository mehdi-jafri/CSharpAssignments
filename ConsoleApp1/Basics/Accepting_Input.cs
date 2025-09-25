using System;

namespace ConsoleApp1.Basics
{
    internal class Accepting_Input
    {
        private string name;
        private int ageInt;

        public void acceptName()
        {
            Console.Write("Enter your name: ");
             name = Console.ReadLine(); // Reads input from the console
        }
        public void acceptAge()
        {
            Console.Write("Enter your age: ");
            string age = Console.ReadLine(); // Reads input from the console , reads as a string only
            ageInt = Int32.Parse(age); // Converts the input to an integer
        }
    
       public void display()
        {
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your Age is: " + ageInt);
        }

    }
}
