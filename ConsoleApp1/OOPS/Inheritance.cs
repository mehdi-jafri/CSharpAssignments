using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class ControlVolume
    {
        private int volume = 100;

        public void increaseVolume()
        {
            volume++;
            Console.WriteLine("Volume increased to: " + volume);
        }

        public void decreaseVolume()
        {
            volume--;
            Console.WriteLine("Volume decreased to: " + volume);
        }
    }
    internal class Child : ControlVolume
    {
        public Child()
        {
            increaseVolume();
            decreaseVolume();
        }

    }

    internal class InheritanceBasic
    {
        static void Main(string[] args)
        {
            // Create an instance of Child class
            Child child = new Child();
            // The constructor of Child will automatically call the methods to increase and decrease volume
            // No need to call them explicitly here
        }
    }
}
