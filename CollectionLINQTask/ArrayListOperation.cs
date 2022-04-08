using System;
using System.Collections;
using System.Diagnostics;
using System.Text;

namespace FirstTask
{
    /// <summary>
    /// Provides methods for working with ArrayList
    /// </summary>
    public class ArrayListOperation
    {
        #region Properties
        /// <summary>
        /// List
        /// </summary>
        private ArrayList _arrayList { get; init; } = new ArrayList();
        
        /// <summary>
        /// Stopwatch
        /// </summary>
        private Stopwatch _stopwatch { get; set; } = new Stopwatch();

        /// <summary>
        /// Random object
        /// </summary>
        private Random _random { get; set; } = new Random();
        #endregion

        #region Public Methods
        /// <summary>
        /// Fills a list with 1024 elements
        /// </summary>
        public void FillingInOneThousandTwentyFour()
        {
            ArrayList newArrayList = new ArrayList();
            _stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newArrayList.Add(_random.Next(1, 1025));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {newArrayList.GetType()} | Count: {newArrayList.Count} | Capacity: {newArrayList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            _stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                _arrayList.Add(_random.Next(1, 10001));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {_arrayList.GetType()} | Count: {_arrayList.Count} | Capacity: {_arrayList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange()
        {
            ArrayList secondArrayList = new ArrayList();
            secondArrayList.AddRange(_arrayList);
            var newArrayListList = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                newArrayListList.Add((_random.Next(1, 10001)));
            }
            _stopwatch.Restart();
            secondArrayList.AddRange(newArrayListList);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondArrayList.GetType()} | Count: {secondArrayList.Count} | Capacity: {secondArrayList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondArrayList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            ArrayList secondArrayList = new ArrayList();
            secondArrayList.AddRange(_arrayList);
            var middle = secondArrayList.Count / 2;
            _stopwatch.Restart();
            secondArrayList.RemoveAt(middle - 1);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondArrayList.GetType()} | Count: {secondArrayList.Count} | Capacity: {secondArrayList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondArrayList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new ArrayList();
            var stringBuilder = new StringBuilder();
            var value = (_random.Next(1, 10001));
            ArrayList secondArrayList = new ArrayList();
            secondArrayList.AddRange(_arrayList);
            _stopwatch.Restart();
            for (int i = 0; i < secondArrayList.Count; i++)
            {
                if ((int)secondArrayList[i] == value)
                {
                    indexes.Add(i);
                }
            }
            _stopwatch.Stop();
            if (indexes.Count == 0)
            {
                Console.WriteLine("There is no such value in the list");
            }
            else
            {
                foreach (var index in indexes)
                {
                    stringBuilder.Append($"{index} ");
                }
                Console.WriteLine($"Collection type: {secondArrayList.GetType()} | Count: {secondArrayList.Count} | Capacity: {secondArrayList.Capacity} | Ticks: {_stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondArrayList.Clear();
            }
            secondArrayList.Clear();
        }
        #endregion
    }
}
