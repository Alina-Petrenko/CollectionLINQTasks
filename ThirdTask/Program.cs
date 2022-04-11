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
                "Aleksandr", "Vladyslav", "Sebastian", "Angelina","Anastasia" , "Vladimir"
            };
            foreach (var name in list)
            {
                Console.Write($"{name} ");
            }
            var result = GetLongest(list);
            Console.WriteLine($"\nLongest and lexicographically first word");
            Console.WriteLine($"{result}");
        }

        /// <summary>
        /// Looks for the longest and lexicographically first word
        /// </summary>
        /// <param name="words">List of words</param>
        /// <returns>Returns longest and lexicographically first word</returns>
        public static string GetLongest(IEnumerable<string> words)
        {
                return words.Where(z => z.Length == words.Max(n => n.Length)).ToList().Min();
             
        }
    }
}
