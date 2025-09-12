using System;

namespace ConsoleApp1.Class_Objects
{
    class Parent
    {
        // Method to calculate Simple Interest
        public double SimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }

    class Child : Parent
    {
        // Method to calculate Compound Interest
        public double CompoundInterest(double principal, double rate, double time)
        {
            // Compound Interest formula: A = P(1 + r/100)^t
            // Compound Interest = A - P
            double amount = principal * Math.Pow((1 + rate / 100), time);
            return amount - principal;
        }
    }

    internal class CalculateInterest
    {
        static void Main()
        {
            Child obj = new Child();

            double principal = 10000;   // example principal amount
            double rate = 10;           // interest rate in percent
            double time = 8;            // time in years

            double simpleInterest = obj.SimpleInterest(principal, rate, time);
            double compoundInterest = obj.CompoundInterest(principal, rate, time);

            Console.WriteLine("Simple Interest for {0} years at {1}% = {2}", time, rate, simpleInterest);
            Console.WriteLine("Compound Interest for {0} years at {1}% = {2}", time, rate, compoundInterest);

            Console.ReadLine();
        }
    }
}
