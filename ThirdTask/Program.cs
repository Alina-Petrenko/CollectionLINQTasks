using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    /// <summary>
    /// Starts the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Prints the results of method call
        /// </summary>
        static void Main()
        {
            var list = new List<string>
            {
                "Vladyslav", "Sebastian", "Angelina","Anastasia" , "Aleksandr", "Vladimir"
            };
            foreach (var name in list)
            {
                Console.Write($"{name} ");
            }
            var result = GetLongest(list);
            Console.WriteLine($"\nLongest and lexicographically first word");
            Console.WriteLine($"{result}");

            var result2 = GetLongest2(list);
            Console.WriteLine($"\nLongest and lexicographically first word");
            Console.WriteLine($"{result2}");
        }

        /// <summary>
        /// Looks for the longest and lexicographically first word
        /// </summary>
        /// <param name="words">List of words</param>
        /// <returns>Returns longest and lexicographically first word</returns>
        public static string GetLongest(IEnumerable<string> words)
        {
            // TODO: Complexity O(3*n):
            // Max()
            // Min()
            // Where()
            return words.Where(z => z.Length == words.Max(n => n.Length)).ToList().Min();
        }

        /// <summary>
        /// Looks for the longest and lexicographically first word
        /// </summary>
        /// <param name="words">List of words</param>
        /// <returns>Returns longest and lexicographically first word</returns>
        public static string GetLongest2(IEnumerable<string> words)
        {
            return words.Min(word => (Length: -word.Length, Word: word)).Word;
        }
    }
}
