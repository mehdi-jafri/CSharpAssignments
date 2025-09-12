using System;

namespace ConsoleApp1.OOPS.Inheritance
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Interface 1
    interface IBarkable2
    {
        void Bark();
    }

    // Interface 2
    interface IWeepable2
    {
        void Weep();
    }

    // Derived class implementing multiple interfaces and inheriting base class
    class Puppy : Animal, IBarkable2, IWeepable2
    {
        public void Bark()
        {
            Console.WriteLine("Puppy is barking.");
        }

        public void Weep()
        {
            Console.WriteLine("Puppy is weeping.");
        }
    }
    internal class Hybrid
    {
        static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }

    }
}
