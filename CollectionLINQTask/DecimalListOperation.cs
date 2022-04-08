using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FirstTask
{
    /// <summary>
    /// Provides methods for working with List<decimal>
    /// </summary>
    public class DecimalListOperation
    {
        #region Properties
        /// <summary>
        /// Decimal List
        /// </summary>
        private List<decimal> _decimalList { get; init; } = new List<decimal>();

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
            List<decimal> newDecimalList = new List<decimal>();
            _stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newDecimalList.Add(_random.Next(1, 1025));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {newDecimalList.GetType()} | Count: {newDecimalList.Count} | Capacity: {newDecimalList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            _stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                _decimalList.Add(_random.Next(1,10001));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {_decimalList.GetType()} | Count: {_decimalList.Count} | Capacity: {_decimalList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange()
        {
            List<decimal> secondDecimalList = new List<decimal>();
            secondDecimalList.AddRange(_decimalList);
            var newDecimalList = new List<decimal>();
            for (int i = 0; i < 100; i++)
            {
                newDecimalList.Add((_random.Next(1, 10001)));
            }
            _stopwatch.Restart();
            secondDecimalList.AddRange(newDecimalList);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondDecimalList.GetType()} | Count: {secondDecimalList.Count} | Capacity: {secondDecimalList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondDecimalList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            List<decimal> secondDecimalList = new List<decimal>();
            secondDecimalList.AddRange(_decimalList);
            var middle = secondDecimalList.Count / 2;
            _stopwatch.Restart();
            secondDecimalList.RemoveAt(middle - 1);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondDecimalList.GetType()} | Count: {secondDecimalList.Count} | Capacity: {secondDecimalList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondDecimalList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new List<int>();
            var stringBuilder = new StringBuilder();
            var value = (_random.Next(1, 10001));
            List<decimal> secondDecimalList = new List<decimal>();
            secondDecimalList.AddRange(_decimalList);
            _stopwatch.Restart();
            for (int i = 0; i < secondDecimalList.Count; i++)
            {
                if (secondDecimalList[i] == value)
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
                Console.WriteLine($"Collection type: {secondDecimalList.GetType()} | Count: {secondDecimalList.Count} | Capacity: {secondDecimalList.Capacity} | Ticks: {_stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondDecimalList.Clear();
            }
            secondDecimalList.Clear();
        }
        #endregion
    }
}
