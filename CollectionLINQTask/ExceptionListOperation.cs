using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FirstTask
{
    /// <summary>
    /// Provides methods for working with List<Exception>
    /// </summary>
    public class ExceptionListOperation
    {
        #region Properties
        /// <summary>
        /// Exception List
        /// </summary>
        private List<Exception> _exceptionList { get; init; } = new List<Exception>();

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
            List<Exception> newExceptionList = new List<Exception>();
            _stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newExceptionList.Add(new Exception ((_random.Next(1, 1025)).ToString()));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {newExceptionList.GetType()} | Count: {newExceptionList.Count} | Capacity: {newExceptionList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            _stopwatch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                _exceptionList.Add(new Exception((_random.Next(1, 10001)).ToString()));
            }
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {_exceptionList.GetType()} | Count: {_exceptionList.Count} | Capacity: {_exceptionList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange()
        {
            List<Exception> secondExceptionList = new List<Exception>();
            secondExceptionList.AddRange(_exceptionList);
            var newExceptionList = new List<Exception>();
            for (int i = 0; i < 100; i++)
            {
                newExceptionList.Add(new Exception((_random.Next(1, 10001)).ToString()));
            }
            _stopwatch.Restart();
            secondExceptionList.AddRange(newExceptionList);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondExceptionList.GetType()} | Count: {secondExceptionList.Count} | Capacity: {secondExceptionList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondExceptionList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            List<Exception> secondExceptionList = new List<Exception>();
            secondExceptionList.AddRange(_exceptionList);
            var middle = secondExceptionList.Count / 2;
            _stopwatch.Restart();
            secondExceptionList.RemoveAt(middle - 1);
            _stopwatch.Stop();
            Console.WriteLine($"Collection type: {secondExceptionList.GetType()} | Count: {secondExceptionList.Count} | Capacity: {secondExceptionList.Capacity} | Ticks: {_stopwatch.ElapsedTicks}");
            secondExceptionList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new List<int>();
            var stringBuilder = new StringBuilder();
            var value = new Exception((_random.Next(1, 10001)).ToString());
            List<Exception> secondExceptionList = new List<Exception>();
            secondExceptionList.AddRange(_exceptionList);
            _stopwatch.Restart();
            for (int i = 0; i < secondExceptionList.Count; i++)
            {
                if (secondExceptionList[i] == value)
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
                Console.WriteLine($"Collection type: {secondExceptionList.GetType()} | Count: {secondExceptionList.Count} | Capacity: {secondExceptionList.Capacity} | Ticks: {_stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondExceptionList.Clear();
            }
            secondExceptionList.Clear();
        }
        #endregion
    }
}
