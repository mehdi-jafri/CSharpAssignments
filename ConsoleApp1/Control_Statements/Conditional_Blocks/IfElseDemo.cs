using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Control_Statements.Conditional_Blocks
{
    internal class IfElseDemo
    {
        string name = "Jack";
        public void CheckName()
        {
            if (name == "Jack")
            {
                Console.WriteLine("Name is Jack");
            }
            else if (name == "John")
            {
                Console.WriteLine("Name is John");
            }
            else
            {
                Console.WriteLine("Name is neither Jack nor John");
            }
        }
        int a = 30; int b = 30;
        public void checkEquality()
        {
            if (a >= b)
            {
                Console.WriteLine("a is greater than or equal to b");
            }
            if(a<b){
                Console.WriteLine("a is less than b");

            }
            if(a == b)
            {
                Console.WriteLine("a is equal to b");
            }
        }
    }
}
