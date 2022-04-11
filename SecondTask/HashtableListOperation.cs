using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SecondTask
{
    public class HashtableListOperation
    {
        #region Properties
        /// <summary>
        /// List
        /// </summary>
        public Hashtable HashTableList { get; init; } = new();

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

        // TODO: Before
        // TODO: too much nesting using if 
        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void FillingWithTenThousand2(bool isReferenceType = true)
        {
            if (HashTableList.Count == 0)
            {
                int counter = 0;
                if (isReferenceType)
                {
                    Stopwatch.Restart();
                    while (counter < 10000)
                    {
                        int value = Random.Next();
                        if (!HashTableList.ContainsKey(value))
                        {
                            if (counter == 9999 || counter == 9998)
                            {
                                // TODO: you will create 2 objects with the same Id.
                                HashTableList.Add(value, new Person(24, "a", 145));
                                counter++;
                            }
                            else
                            {
                                HashTableList.Add(value, new Person());
                                counter++;
                            }
                        }
                    }

                    Stopwatch.Stop();
                }
                else
                {
                    Stopwatch.Restart();
                    while (counter < 10000)
                    {
                        int value = Random.Next();
                        if (!HashTableList.ContainsKey(value))
                        {
                            HashTableList.Add(value, Random.Next(1, 10001));
                            counter++;
                        }
                    }
                    Stopwatch.Stop();
                }
            }

            ResultOutput(HashTableList);
        }

        // TODO: After
        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void FillingWithTenThousand(bool isReferenceType = true)
        {
            if (HashTableList.Count != 0)
            {
                return;
            }

            Stopwatch.Restart();
            this.FillHashTable(isReferenceType);
            Stopwatch.Stop();

            ResultOutput(HashTableList);
        }

        // TODO: The idea of the task was to check the time of adding new element into collection
        // TODO: Before
        /// <summary>
        /// Appends value to the end of list
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void ListAdd2(bool isReferenceType = true)
        {
            Hashtable secondHashtable = new(HashTableList);
            var counter = 0;
            if (isReferenceType)
            {
                Stopwatch.Restart();
                while (counter < 1)
                {
                    var key = Random.Next();
                    if (HashTableList.ContainsKey(key)) 
                        continue;

                    secondHashtable.Add(key, new Person());
                    counter++;
                }
                Stopwatch.Stop();
            }
            else
            {
                Stopwatch.Restart();
                while (counter < 1)
                {
                    var key = Random.Next();
                    if (HashTableList.ContainsKey(key)) 
                        continue;

                    secondHashtable.Add(key, Random.Next(1, 10001));
                    counter++;
                }
                Stopwatch.Stop();
            }
            ResultOutput(secondHashtable);
            secondHashtable.Clear();
        }

        // TODO: After
        /// <summary>
        /// Appends value to the end of list
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void ListAdd(bool isReferenceType = true)
        {
            Hashtable secondHashtable = new(HashTableList);

            Stopwatch.Restart();
            secondHashtable.Add("Added", isReferenceType ? new Person() : Random.Next());
            Stopwatch.Stop();
            
            ResultOutput(secondHashtable);
            secondHashtable.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            Hashtable secondHashtable = new(HashTableList);
            var middle = secondHashtable.Count / 2;
            var listKey = new int[secondHashtable.Count];
            secondHashtable.Keys.CopyTo(listKey, 0);
            var index = listKey[middle - 1];
            Stopwatch.Restart();
            secondHashtable.Remove(index);
            Stopwatch.Stop();
            ResultOutput(secondHashtable);
            secondHashtable.Clear();
        }

        /// <summary>
        /// Finds the index of first occurrence of an element in list
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void Find(bool isReferenceType = true)
        {
            var secondHashtable = new Hashtable(HashTableList);
            var index = string.Empty;
            if (isReferenceType)
            {
                var valueRef = new Person(24, "a", 145);
                if (!secondHashtable.ContainsValue(valueRef))
                {
                    Console.WriteLine("There is no such value in the list");
                }
                else
                {
                    Stopwatch.Restart();
                    foreach (var item in secondHashtable.Cast<DictionaryEntry>().Where(item => valueRef.Equals((Person)(item.Value))))
                    {
                        index = item.Key.ToString();
                    }
                    Stopwatch.Stop();
                    Console.WriteLine($"Collection type: {secondHashtable.GetType()} | Count: {secondHashtable.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {valueRef.Name}, {valueRef.Age} | Index: {index}");
                }
            }
            else
            {
                var value = Random.Next(1, 10001);
                if (!secondHashtable.ContainsValue(value))
                {
                    Console.WriteLine("There is no such value in the list");
                }
                else
                {
                    Stopwatch.Restart();
                    foreach (var item in secondHashtable.Cast<DictionaryEntry>().Where(item => value == Convert.ToInt32(item.Value)))
                    {
                        index = item.Key.ToString();
                    }
                    Stopwatch.Stop();
                    Console.WriteLine($"Collection type: {secondHashtable.GetType()} | Count: {secondHashtable.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value} | Index: {index}");
                }
            }
            secondHashtable.Clear();
        }

        /// <summary>
        /// Finds all indexes of occurrences of an element in list
        /// </summary>
        /// <param name="isReferenceType">True - generate objects, false - generate structs</param>
        public void FindAll(bool isReferenceType = true)
        {
            var secondHashtable = new Hashtable(HashTableList);
            var listKeys = new List<string>();
            var stringBuilder = new StringBuilder();
            if (isReferenceType)
            {
                var valueRef = new Person(24, "a", 145);
                if (!secondHashtable.ContainsValue(valueRef))
                {
                    Console.WriteLine("There is no such value in the list");
                }
                else
                {
                    Stopwatch.Restart();
                    foreach (DictionaryEntry item in secondHashtable)
                    {
                        if (valueRef.Equals((Person)(item.Value)))
                        {
                            listKeys.Add(item.Key.ToString());
                        }
                    }
                    Stopwatch.Stop();
                    foreach (var item in listKeys)
                    {
                        stringBuilder.Append($"{item} ");
                    }
                    Console.WriteLine($"Collection type: {secondHashtable.GetType()} | Count: {secondHashtable.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {valueRef.Name}, {valueRef.Age} | Indexes: {stringBuilder}");
                    secondHashtable.Clear();
                }
                secondHashtable.Clear();
            }
            else
            {
                var value = (Random.Next(1, 10001));
                if (!secondHashtable.ContainsValue(value))
                {
                    Console.WriteLine("There is no such value in the list");
                }
                else
                {
                    Stopwatch.Restart();
                    foreach (DictionaryEntry item in secondHashtable)
                    {
                        if (value == Convert.ToInt32(item.Value))
                        {
                            listKeys.Add(item.Key.ToString());
                        }
                    }
                    Stopwatch.Stop();
                    foreach (var item in listKeys)
                    {
                        stringBuilder.Append($"{item} ");
                    }
                    Console.WriteLine($"Collection type: {secondHashtable.GetType()} | Count: {secondHashtable.Count} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                    secondHashtable.Clear();
                }
                secondHashtable.Clear();
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Writes result to console
        /// </summary>
        /// <param name="hashtable">Hashtable List</param>
        private void ResultOutput(ICollection hashtable)
        {
            Console.WriteLine($"Collection type: {hashtable.GetType()} | Count: {hashtable.Count} | Ticks: {Stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Fills <see cref="Hashtable"/> type by random values
        /// </summary>
        /// <param name="isReferenceType">true - use <see cref="Person"/> object for value, false - use value type for value</param>
        private void FillHashTable(bool isReferenceType = false)
        {
            var counter = 0;
            while (counter < 10000)
            {
                if (HashTableList.ContainsKey(counter))
                    continue;

                HashTableList.Add(counter, isReferenceType ? new Person(24, $"Mike{counter}", counter) : counter);
                counter++;
            }
        }
        #endregion
    }
}
