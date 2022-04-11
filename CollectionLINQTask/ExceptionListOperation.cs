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
        private List<Exception> ExceptionList { get; init; } = new();

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
        /// Fills a list with 1024 elements
        /// </summary>
        public void FillingInOneThousandTwentyFour()
        {
            List<Exception> newExceptionList = new List<Exception>();
            Stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newExceptionList.Add(new Exception((Random.Next(1, 1025)).ToString()));
            }
            Stopwatch.Stop();
            ResultOutput(newExceptionList);
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            if (ExceptionList.Count == 0)
            {
                Stopwatch.Restart();
                for (var i = 0; i < 10000; i++)
                {
                    ExceptionList.Add(new Exception(Random.Next(1, 10001).ToString()));
                }
                Stopwatch.Stop();
            }
            ResultOutput(ExceptionList);
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange(int count)
        {
            List<Exception> secondExceptionList = new List<Exception>(ExceptionList);
            var newExceptionList = new List<Exception>();
            for (int i = 0; i < count; i++)
            {
                newExceptionList.Add(new Exception((Random.Next(1, 10001)).ToString()));
            }
            Stopwatch.Restart();
            secondExceptionList.AddRange(newExceptionList);
            Stopwatch.Stop();
            ResultOutput(secondExceptionList);
            secondExceptionList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            List<Exception> secondExceptionList = new List<Exception>(ExceptionList);
            var middle = secondExceptionList.Count / 2;
            Stopwatch.Restart();
            secondExceptionList.RemoveAt(middle - 1);
            Stopwatch.Stop();
            ResultOutput(secondExceptionList);
            secondExceptionList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new List<int>();
            var stringBuilder = new StringBuilder();
            var value = new Exception((Random.Next(1, 10001)).ToString());
            var secondExceptionList = new List<Exception>(ExceptionList);
            Stopwatch.Restart();
            for (int i = 0; i < secondExceptionList.Count; i++)
            {
                if (secondExceptionList[i] == value)
                {
                    indexes.Add(i);
                }
            }
            Stopwatch.Stop();
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
                stringBuilder.Remove(stringBuilder.Length - 3, 2);
                Console.WriteLine($"Collection type: {secondExceptionList.GetType()} | Count: {secondExceptionList.Count} | Capacity: {secondExceptionList.Capacity} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondExceptionList.Clear();
            }
            secondExceptionList.Clear();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Writes result to console
        /// </summary>
        /// <param name="exceptionList">Exception List</param>
        private void ResultOutput(List<Exception> exceptionList)
        {
            Console.WriteLine($"Collection type: {exceptionList.GetType()} | Count: {exceptionList.Count} | Capacity: {exceptionList.Capacity} | Ticks: {Stopwatch.ElapsedTicks}");
        }
        #endregion
    }
}
