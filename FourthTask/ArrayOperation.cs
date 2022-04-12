using System;
using System.Collections.Generic;
using System.Linq;

namespace FourthTask
{
    /// <summary>
    /// The class represents operations on arrays
    /// </summary>
    public class ArrayOperation
    {
        #region Public Methods
        /// <summary>
        /// Gets index of first non-null element in <paramref name="array"/>
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Index of first non-null element</returns>
        public int GetIndexFirstNonNullElement (int [] array)
        {
            return Array
                .IndexOf(array, (array.Where(item => item != 0)
                .First()));
        }

        /// <summary>
        /// Multiplies an <paramref name="array"/> by itself
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Returns result of multiply</returns>
        public int[] MultiplyNumbers (int[] array)
        {
            return array.AsParallel()
                .Select(item => item * item)
                .ToArray();
        }

        /// <summary>
        /// Calculates the number of matching words in a string
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Returns an array of tuples with the values word - number of repetitions</returns>
        public (string word, int count)[] FindWordCount(string[] array)
        {
            return array.GroupBy(item => item, StringComparer.OrdinalIgnoreCase)
                .Select(g => (g.Key, g.Count()))
                .OrderBy(item => item.Key)
                .ToArray();
        }

        /// <summary>
        /// Connects <paramref name="firstArray"/> and <paramref name="secondArray"/> and writes values to the Dictionary, where key is a number, value is the number of repetitions of the number
        /// </summary>
        /// <param name="firstArray">First int array</param>
        /// <param name="secondArray">Second int array</param>
        /// <returns>Returns a dictionary where the key is a number from the arrays and the value is the number of repetitions of this number in these arrays</returns>
        public Dictionary<int,int> Dictionary (int [] firstArray, int [] secondArray)
        {
            return firstArray.Concat(secondArray)
                .GroupBy(item => item)
                .OrderBy(item => item.Key)
                .Select(group => new
                {
                    Key = group.Key,
                    Value = group.Count()
                })
                .ToDictionary(key => key.Key, value => value.Value);
        }
#endregion
    }
}
