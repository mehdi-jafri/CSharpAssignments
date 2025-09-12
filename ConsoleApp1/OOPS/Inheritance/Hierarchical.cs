using System;

namespace ConsoleApp1.OOPS.Inheritance
{
    class Animal3
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog3 : Animal3
    {
        public void Barks()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class Cat3 : Animal3
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing.");
        }
    }
    internal class Hierarchical
    {
        static void Main(string[] args)
        {
            Dog3 dog = new Dog3();
            dog.Eat();  // From Animal
            dog.Barks(); // From Dog
            Cat3 cat = new Cat3();
            cat.Eat();  // From Animal
            cat.Meow(); // From Cat
        }
    }
}
