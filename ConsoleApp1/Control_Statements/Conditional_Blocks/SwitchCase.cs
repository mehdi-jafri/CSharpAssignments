using System;

namespace ConsoleApp1.Control_Statements.Conditional_Blocks
{
    internal class SwitchCase
    {
        public void CheckDay(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
        // NOTE : Same value 2 cases cannot be formed in switch case
        public void checkName(string name)
        {
            switch (name)
            {
                case "Jack":
                    Console.WriteLine("Name is Jack");
                    break;
                case "John":
                    Console.WriteLine("Name is John");
                    break;
                default:
                    Console.WriteLine("Name is neither Jack nor John");
                    break;
            }
        }

        static void Main(string[] args)
        {
            SwitchCase switchCase = new SwitchCase();
            Console.WriteLine("Enter a day number (1-7):");
            int day = Convert.ToInt32(Console.ReadLine());
            switchCase.CheckDay(day);
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            switchCase.checkName(name);
        }
    }
}
