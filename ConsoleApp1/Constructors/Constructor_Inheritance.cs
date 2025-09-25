using System;

namespace ConsoleApp1.Constructors
{
    class Animal6
    {
        public string Name;

        // Base class parameterized constructor
        public Animal6(string name)
        {
            Name = name;
            Console.WriteLine("Animal constructor called");
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
        }
    }

    class Dog6 : Animal6
    {
        public string Breed;

        // Derived class constructor calls base class constructor
        public Dog6(string name, string breed) : base(name)
        {
            Breed = breed;
            Console.WriteLine("Dog constructor called");
        }

        public void ShowBreed()
        {
            Console.WriteLine("Breed: " + Breed);
        }
    }

    internal class Constructor_Inheritance
    {
        public static void Main(string[] args) // Fix: Added a Main method to serve as the entry point
        {
            Dog6 ob = new Dog6("Buddy", "Golden Retriever"); // Fix: Moved object creation inside a method
            ob.Display();    // From base class
            ob.ShowBreed();  // From derived class
        }
    }
}
