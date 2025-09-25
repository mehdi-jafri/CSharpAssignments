using System;
namespace ConsoleApp1.Arrays
{
    internal class SearchArrayElement
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        public void SearchElement() // Renamed method to avoid conflict with class name
        {
            int target = 3;
            bool found = false;

            // Linear search
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine("Element found at index: " + i);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Element not found in the array.");
            }
        }

        static void Main(string[] args)
        {
            SearchArrayElement searchArrayElement = new SearchArrayElement();
            searchArrayElement.SearchElement(); // Updated method call to match the new name
        }
    }
}
