using System;

namespace ConsoleApp1.OOPS.Inheritance
{
    class Animal1
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    class Dog1 : Animal1
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    internal class Single
    {
        static void Main()
        {
            Dog1 dog = new Dog1();
            dog.Eat();  // From Animal
            dog.Bark(); // From Dog
        }
    }
}
