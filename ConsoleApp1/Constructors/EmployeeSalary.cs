using System;

namespace ConsoleApp1.Constructors
{
    class Employee
    {
        private double basic;
        private double ta;
        private double da;

        // Constructor to initialize fields
        public Employee(double basic, double ta, double da)
        {
            this.basic = basic;
            this.ta = ta;
            this.da = da;
        }

        // Method to calculate and display salary
        public void DisplaySalary()
        {
            double salary = basic + ta + da;
            Console.WriteLine("Salary of the employee: " + salary);
        }
    }
    internal class EmployeeSalary
    {
        static void Main()
        {
            // Create employee with basic=20000, ta=3000, da=2000 , basic is the base salary, ta is the travel allowance, and da is the dearness allowance
            Employee emp = new Employee(20000, 3000, 2000);

            emp.DisplaySalary();

            Console.ReadLine();
        }
    }
}
