using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS.Inheritance
{
    interface IAnimal
    {
        void Eat();
    }

    interface IBarkable
    {
        void Bark();
    }

    class Dog4 : IAnimal, IBarkable
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
    internal class Multiple_ByInterfaces
    {
        static void Main()
        {
            Dog4 dog = new Dog4();
            dog.Eat();
            dog.Bark();
        }
    }
}
