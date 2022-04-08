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
        private List<decimal> DecimalList { get; init; } = new();

        /// <summary>
        /// Stopwatch
        /// </summary>
        private Stopwatch Stopwatch { get; set; } = new();

        /// <summary>
        /// Random object
        /// </summary>
        private Random Random { get; set; } = new();
        #endregion

        #region Public Methods
        /// <summary>
        /// Fills a list with 1024 elements
        /// </summary>
        public void FillingInOneThousandTwentyFour()
        {
            List<decimal> newDecimalList = new List<decimal>();

            Stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newDecimalList.Add(Random.Next(1, 1025));
            }
            Stopwatch.Stop();
            ResultOutput(newDecimalList);
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            if (DecimalList.Count == 0)
            {
                Stopwatch.Restart();
                for (int i = 0; i < 10000; i++)
                {
                    DecimalList.Add(Random.Next(1, 10001));
                }
                Stopwatch.Stop();
            }
            ResultOutput(DecimalList);
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange(int count)
        {
            List<decimal> secondDecimalList = new List<decimal>(DecimalList);
            var newDecimalList = new List<decimal>();
            for (int i = 0; i < count; i++)
            {
                newDecimalList.Add((Random.Next(1, 10001)));
            }
            Stopwatch.Restart();
            secondDecimalList.AddRange(newDecimalList);
            Stopwatch.Stop();
            ResultOutput(secondDecimalList);
            secondDecimalList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            List<decimal> secondDecimalList = new List<decimal>(DecimalList);
            var middle = secondDecimalList.Count / 2;
            Stopwatch.Restart();
            secondDecimalList.RemoveAt(middle - 1);
            Stopwatch.Stop();
            ResultOutput(secondDecimalList);
            secondDecimalList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new List<int>();
            var stringBuilder = new StringBuilder();
            var value = (Random.Next(1, 10001));
            var secondDecimalList = new List<decimal>(DecimalList);
            Stopwatch.Restart();
            for (int i = 0; i < secondDecimalList.Count; i++)
            {
                if (secondDecimalList[i] == value)
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
                Console.WriteLine($"Collection type: {secondDecimalList.GetType()} | Count: {secondDecimalList.Count} | Capacity: {secondDecimalList.Capacity} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondDecimalList.Clear();
            }
            secondDecimalList.Clear();
        }

        /// <summary>
        /// Process collection values 
        /// </summary>
        public void ProcessValues()
        {
            var counter = 0;
            var numberReceiver = 0m;
            Stopwatch.Start();
            foreach (var number in DecimalList)
            {
                numberReceiver = number;
                counter++;
            }
            Stopwatch.Stop();
            Console.WriteLine($"Processed: {counter} numbers | Last number: {numberReceiver} | Elapsed time: {Stopwatch.ElapsedTicks}");
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Writes result to console
        /// </summary>
        /// <param name="decimalList">Decimal List</param>
        private void ResultOutput(List<decimal> decimalList)
        {
            Console.WriteLine($"Collection type: {decimalList.GetType()} | Count: {decimalList.Count} | Capacity: {decimalList.Capacity} | Ticks: {Stopwatch.ElapsedTicks}");

        }
        #endregion
    }
}
