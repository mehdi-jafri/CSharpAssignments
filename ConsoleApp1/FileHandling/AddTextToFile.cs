using System;
using System.IO;

namespace ConsoleApp1.FileHandling
{
    internal class AddTextToFile
    {
        static void Main(string[] args)
        {
            string filePath = "SampleFile.txt"; // File path

            // Create the file if it does not exist
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("File created: " + filePath);
            }

            Console.WriteLine("You can start adding text to the file. Type 'exit' to stop.");

            while (true)
            {
                Console.Write("Enter text: ");
                string textToAdd = Console.ReadLine();

                if (textToAdd.ToLower() == "exit")
                    break;

                try
                {
                    File.AppendAllText(filePath, textToAdd + Environment.NewLine);
                    Console.WriteLine("Text added successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            Console.WriteLine("Finished writing to the file. Press any key to exit...");
            Console.ReadKey();
        }
    }
}
