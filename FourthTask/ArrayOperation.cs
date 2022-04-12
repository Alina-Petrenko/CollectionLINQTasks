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
        /// Gets index of first non-zero element in <paramref name="array"/>
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Index of first non-null element</returns>
        public int GetIndexFirstNonZeroElement(int[] array)
        {
            // TODO: Before
            //return Array
            //    .IndexOf(array, (array.Where(item => item != 0)
            //    .First()));

            // TODO: After
            return Array.FindIndex(array, item => item != 0);
        }

        /// <summary>
        /// Multiplies an <paramref name="array"/> by itself
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Returns result of multiply</returns>
        public int[] MultiplyNumbers(int[] array)
        {
            return array.AsParallel()
                .Select(item => item * item)
                .ToArray();
        }

        /// <summary>
        /// Calculates count of each word in a strings and sort them by count
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>Returns an array of tuples with key - word, value - count of repetitions</returns>
        public Dictionary<string, int> GetWordsCount(string[] array)
        {
            // TODO: Before
            //return array.GroupBy(item => item, StringComparer.OrdinalIgnoreCase)
            //    .Select(g => (g.Key, g.Count()))
            //    .OrderBy(item => item.Key)
            //    .ToArray();

            // TODO: After
            return array.GroupBy(item => item, StringComparer.OrdinalIgnoreCase)
                .Select(g => (g.Key, Count: g.Count()))
                .OrderBy(item => item.Count)
                .ToDictionary(k => k.Key, v => v.Count);
        }

        /// <summary>
        /// Connects <paramref name="firstArray"/> and <paramref name="secondArray"/> and writes values to the Dictionary, where key is a number, value is the number of repetitions of the number
        /// </summary>
        /// <param name="firstArray">First int array</param>
        /// <param name="secondArray">Second int array</param>
        /// <returns>Returns a dictionary where the key is a number from the arrays and the value is the number of repetitions of this number in these arrays</returns>
        public Dictionary<int, int> GetWordsCountInArrays(int[] firstArray, int[] secondArray)
        {
            // TODO: Before
            //return firstArray.Concat(secondArray)
            //    .GroupBy(item => item)
            //    .OrderBy(item => item.Key)
            //    .Select(group => new
            //    {
            //        Key = group.Key,
            //        Value = group.Count()
            //    })
            //    .ToDictionary(key => key.Key, value => value.Value);

            // TODO: After
            return firstArray.Concat(secondArray)
                .GroupBy(item => item)
                .OrderBy(item => item.Key)
                .ToDictionary(key => key.Key, value => value.Count());
        }
        #endregion
    }
}
