using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOPS
{
    internal class Encapsulation
    {
        static void Main(String[] args)
        {
            Details d=new Details(); 
                    d.addBalance(1000); 
                   Console.WriteLine( d.getBalance() ); // This will return the current balance
        }

    }

    public class Details
    {

        private int balance;

        public void addBalance(int value)
        {
            balance+= value; // Add the value to the balance
        }

        public int getBalance()
        {
            return balance; // Return the current balance
        }
    }
}
