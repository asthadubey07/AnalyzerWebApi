using System;
using System.Linq;

namespace UniqueElementsApp
{
    /// <summary>
    /// Provides functionality to find and display non-repeating elements in an array.
    /// </summary>
    public static class UniqueElementsFinder1
    {
        /// <summary>
        /// The entry point of the application. Finds and displays non-repeating elements in the array.
        /// </summary>
        public static void Main()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };

            // Group elements and select those that appear only once
            var nonRepeating = numbers
                .GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key);

            Console.WriteLine("Non-repeating elements:");
            foreach (var num in nonRepeating)
            {
                Console.WriteLine(num);
            }
        }
    }
}
