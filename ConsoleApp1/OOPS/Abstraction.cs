using System;

namespace ConsoleApp1.OOPS
{
    internal abstract class Abstract_Class
    {
        public abstract void display(); // Abstract method without body

        public void show() // Regular method with body
        {
            Console.WriteLine("This is a regular method in an abstract class.");
        }
    }

    internal class Abstraction : Abstract_Class
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new Abstraction();
            abstraction.display(); // Calling the implemented method
            abstraction.show(); // Calling the regular method
        }
        public override void display() // Implementing the abstract method
        {
            Console.WriteLine("This is an implementation of the abstract method.");
        }
    }

    
}
