using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constructors
{
    class Car2
    {
        private string model;
        private string name;

        public Car2(string model, string name)
        {
            this.model = model;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Car Model: " + model);
            Console.WriteLine("Car Name: " + name);
        }

        // Protected method to be overridden
        protected virtual void ShowMsg()
        {
            Console.WriteLine("Message from Car class.");
        }
    }

    class CarMarket2 : Car2
    {
        public CarMarket2(string model, string name) : base(model, name)
        {
        }

        public void ShowCarDetails()
        {
            Display();
        }

        // Override protected method
        protected override void ShowMsg()
        {
            base.ShowMsg(); // call base class method
            Console.WriteLine("Additional message from CarMarket class.");
        }

        // Expose protected ShowMsg via a public method to allow calling from subclass
        public void CallShowMsg()
        {
            ShowMsg();
        }
    }

    class CarShowRoom : CarMarket2
    {
        public CarShowRoom(string model, string name) : base(model, name)
        {
        }

        // Method that calls protected ShowMsg(), base class Display() and ShowCarDetails()
        public void ShowAllDetails()
        {
            // Call protected method ShowMsg() from CarMarket (which also calls Car's ShowMsg)
            ShowMsg();

            // Call Display method from Car
            Display();

            // Call ShowCarDetails() from CarMarket
            ShowCarDetails();
        }
    }

    internal class Extended_Constructor_Inheritance
    {
        static void Main()
        {
            CarShowRoom showroom = new CarShowRoom("Model X", "Tesla");

            // Call the method that demonstrates calling methods from all three classes
            showroom.ShowAllDetails();

            Console.ReadLine();
        }
    }
}
