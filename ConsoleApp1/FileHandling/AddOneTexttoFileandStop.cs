using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FileHandling
{
    internal class AddOneTexttoFileandStop
    {
        static void Main(string[] args)
        {
            string filePath = "SampleFile2.txt"; // File path

            // Create the file if it does not exist
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("File created: " + filePath);
            }

            Console.Write("Enter text to add to the file: ");
            string textToAdd = Console.ReadLine();

            try
            {
                File.AppendAllText(filePath, textToAdd + Environment.NewLine);
                Console.WriteLine("Text added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
