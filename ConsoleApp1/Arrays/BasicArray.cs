using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Arrays
{
    internal class BasicArray
    {
        public void display() { 
           
            int[] no = { 10, 11, 12, 13, 14, 15 };

            string[] city = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };

            string[] country;
            country = new string[] { "USA", "Canada", "UK", "Australia", "India" };

            int[] rollno; // Declare an array 
          
           rollno=new int[5]; // Initialize the array with a size of 5 (allocate memory for 5)
                  rollno[0]=10;
                  rollno[1]=11;
                  rollno[2]=12;
                  rollno[3]=13;
                  rollno[4]=14;

            string[] name = new string[5];
                     name[0] = "John";
                     name[1] = "Jack";
                     name[2] = "Jill";
                     name[3] = "Jane";
                     name[4] = "Joe";

            Console.WriteLine("Roll Numbers 02:" + rollno[2]);
            Console.WriteLine("Name :"+name[2]);

            Console.WriteLine("Roll Numbers in the array:");

            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine("Roll Number " + (i + 1) + ": " + rollno[i]);
            }

            Console.WriteLine("Names in the array:");
            for(int i=0;i< 5;i++)
            {
                Console.WriteLine("Name " + (i + 1) + ": " + name[i]);
            }

        }

        static void Main(string[] args)
        {
            BasicArray basicArray = new BasicArray();
            basicArray.display(); // Calling the display method to show array contents
        }

    }
}
