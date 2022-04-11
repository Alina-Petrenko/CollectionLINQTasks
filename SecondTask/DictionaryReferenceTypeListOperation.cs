using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SecondTask
{
    public class DictionaryReferenceTypeListOperation
    {
        #region Properties
        /// <summary>
        /// List
        /// </summary>
        private Dictionary<int, Person> DictionaryList { get; init; } = new();

        /// <summary>
        /// Stopwatch
        /// </summary>
        private Stopwatch Stopwatch { get; } = new();

        /// <summary>
        /// Random object
        /// </summary>
        private Random Random { get; } = new();
        #endregion

        #region Public Methods
        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            if (DictionaryList.Count == 0)
            {
                int counter = 0;
                Stopwatch.Restart();
                while (counter < 10000)
                {
                    int value = Random.Next();
                    if (!DictionaryList.ContainsKey(value))
                    {
                        if (counter == 9999 || counter == 9998)
                        {
                            DictionaryList.Add(value, new Person(24, "a", 145));
                            counter++;
                        }
                        else
                        {
                            DictionaryList.Add(value, new Person());
                            counter++;
                        }
                    }
                }

                Stopwatch.Stop();
            }
            ResultOutput(DictionaryList);
        }

        /// <summary>
        /// Appends value to the end of list
        /// </summary>
        public void ListAdd()
        {
            Dictionary<int, Person> secondDictionary = new(DictionaryList);
            int counter = 0;
            Stopwatch.Restart();
            while (counter < 1)
            {
                int key = Random.Next();
                if (!DictionaryList.ContainsKey(key))
                {
                    secondDictionary.Add(key, new Person());
                    counter++;
                }
            }
            Stopwatch.Stop();
            ResultOutput(secondDictionary);
            secondDictionary.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            Dictionary<int, Person> secondDictionary = new(DictionaryList);
            var middle = secondDictionary.Count / 2;
            var listKey = new int[secondDictionary.Count];
            secondDictionary.Keys.CopyTo(listKey, 0);
            var index = listKey[middle - 1];
            Stopwatch.Restart();
            secondDictionary.Remove(index);
            Stopwatch.Stop();
            ResultOutput(secondDictionary);
            secondDictionary.Clear();
        }

        /// <summary>
        /// Finds the index of first occurrence of an element in list
        /// </summary>
        public void Find()
        {
            var value = new Person(24, "a", 145);
            var secondDictionary = new Dictionary<int, Person>(DictionaryList);
            string index = String.Empty;
            if (!secondDictionary.ContainsValue(value))
            {
                Console.WriteLine("There is no such value in the list");
            }
            else
            {
                Stopwatch.Restart();
                foreach (var item in secondDictionary)
                {
                    if (value.Equals((Person)(item.Value)))
                    {
                        index = item.Key.ToString();
                        continue;
                    }
                }
                Stopwatch.Stop();
                Console.WriteLine($"Collection type: {secondDictionary.GetType()} | Count: {secondDictionary.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value.Name}, {value.Age} | Index: {index}");
                secondDictionary.Clear();
            }
        }

        /// <summary>
        /// Finds all indexes of occurrences of an element in list
        /// </summary>
        public void FindAll()
        {
            var secondDictionary = new Dictionary<int, Person>(DictionaryList);
            var listKeys = new List<string>();
            var stringBuilder = new StringBuilder();
            var value = new Person(24, "a", 145);
            if (!secondDictionary.ContainsValue(value))
            {
                Console.WriteLine("There is no such value in the list");
            }
            else
            {
                Stopwatch.Restart();
                foreach (var item in secondDictionary)
                {
                    if (value.Equals((Person)(item.Value)))
                    {
                        listKeys.Add(item.Key.ToString());
                    }
                }
                Stopwatch.Stop();
                foreach (var item in listKeys)
                {
                    stringBuilder.Append($"{item} ");
                }
                Console.WriteLine($"Collection type: {secondDictionary.GetType()} | Count: {secondDictionary.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value.Name}, {value.Age} | Index: {stringBuilder}");
                secondDictionary.Clear();
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Writes result to console
        /// </summary>
        /// <param name="dictionary">Dictionary List</param>
        private void ResultOutput(Dictionary<int, Person> dictionary)
        {
            Console.WriteLine($"Collection type: {dictionary.GetType()} | Count: {dictionary.Count} | Ticks: {Stopwatch.ElapsedTicks}");
        }
        #endregion
    }
}

