using System;


namespace ConsoleApp1.OOPS.Inheritance
{
    // Base class
    class Animal2
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Derived class 1
    class Dog2 : Animal2
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Derived class 2
    class Puppy2 : Dog2
    {
        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }
    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Puppy2 myPuppy = new Puppy2();

            myPuppy.Eat();   // Inherited from Animal
            myPuppy.Bark();  // Inherited from Dog
            myPuppy.Weep();  // Defined in Puppy

           // Console.ReadLine();
        }
    }
}
