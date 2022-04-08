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
        private ArrayList ArrayList { get; init; } = new();

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
            ArrayList newArrayList = new ArrayList();
            Stopwatch.Restart();
            for (int i = 0; i < 1024; i++)
            {
                newArrayList.Add(Random.Next(1, 1025));
            }
            Stopwatch.Stop();

            ResultOutput(newArrayList);
        }

        /// <summary>
        /// Fills a list with 10000 elements
        /// </summary>
        public void FillingWithTenThousand()
        {
            if (ArrayList.Count == 0)
            {
                Stopwatch.Restart();
                for (int i = 0; i < 10000; i++)
                {
                    ArrayList.Add(Random.Next(1, 10001));
                }
                Stopwatch.Stop();
            }
            ResultOutput(ArrayList);
        }

        /// <summary>
        /// Appends one list to the end of another
        /// </summary>
        public void ListAddRange(int count)
        {
            ArrayList secondArrayList = new ArrayList(ArrayList);
            var newArrayListList = new ArrayList();
            for (int i = 0; i < count; i++)
            {
                newArrayListList.Add((Random.Next(1, 10001)));
            }
            Stopwatch.Restart();
            secondArrayList.AddRange(newArrayListList);
            Stopwatch.Stop();
            ResultOutput(secondArrayList);
            secondArrayList.Clear();
        }

        /// <summary>
        /// Removes the element in the middle of the list
        /// </summary>
        public void Remove()
        {
            ArrayList secondArrayList = new ArrayList();
            secondArrayList.AddRange(ArrayList);
            var middle = secondArrayList.Count / 2;
            Stopwatch.Restart();
            secondArrayList.RemoveAt(middle - 1);
            Stopwatch.Stop();
            ResultOutput(secondArrayList);
            secondArrayList.Clear();
        }

        /// <summary>
        /// Finds the indexes of all occurrences of an element in list
        /// </summary>
        public void Find()
        {
            var indexes = new ArrayList();
            var stringBuilder = new StringBuilder();
            var value = (Random.Next(1, 10001));
            ArrayList secondArrayList = new ArrayList(ArrayList);
            Stopwatch.Restart();
            for (int i = 0; i < secondArrayList.Count; i++)
            {
                var number = Convert.ToInt32(secondArrayList[i]);
                if (number == value)
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
                Console.WriteLine($"Collection type: {secondArrayList.GetType()} | Count: {secondArrayList.Count} | Capacity: {secondArrayList.Capacity} | Ticks: {Stopwatch.ElapsedTicks} | Value: {value} | Indexes: {stringBuilder}");
                secondArrayList.Clear();
            }
            secondArrayList.Clear();
        }

        /// <summary>
        /// Process collection values 
        /// </summary>
        public void ProcessValues()
        {
            var counter = 0;
            var numberReceiver = 0m;
            Stopwatch.Start();
            foreach (var number in ArrayList)
            {
                numberReceiver = Convert.ToDecimal(number);
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
        /// <param name="arrayList">ArrayList List</param>
        private void ResultOutput(ArrayList arrayList)
        {
            Console.WriteLine($"Collection type: {arrayList.GetType()} | Count: {arrayList.Count} | Capacity: {arrayList.Capacity} | Ticks: {Stopwatch.ElapsedTicks}");
        }
        #endregion
    }

}

