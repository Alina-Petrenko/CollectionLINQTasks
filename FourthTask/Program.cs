using System;

namespace FourthTask
{
    /// <summary>
    /// Starts the project
    /// </summary>
    public class Program
    {
        #region Public Methods
        /// <summary>
        /// Prints the results of method calls
        /// </summary>
        static void Main()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            var firstIntArray = FillArrayByRandomNumbers();
            Console.WriteLine("First Int Array");
            IntArrayOutput(firstIntArray);
            var secondIntArray = FillArrayByRandomNumbers();
            Console.WriteLine("\nSecond Int Array");
            IntArrayOutput(secondIntArray);

            var multiplyElement = arrayOperation.MultiplyNumbers(firstIntArray);
            Console.WriteLine("\nResult of Array multiplication of first array\n");
            IntArrayOutput(multiplyElement);

            var indexFirstNonNullElement = arrayOperation.GetIndexFirstNonNullElement(firstIntArray);
            Console.WriteLine($"\nIndex of first non-null element in first Array: {indexFirstNonNullElement}");

            Console.WriteLine("Dictionary");
            var dictionary = arrayOperation.Dictionary(firstIntArray, secondIntArray);
            foreach (var element in dictionary)
            {
                Console.WriteLine($"Number: {element.Key}, Count: {element.Value} ");
            }         

            var text = "I have read your letter at e - mailfriends and would like to make friends with you! Let me introduce myself. My name is Hans. I live in Berlin. I am 20. I live with my parents. My mother is a doctor. When I feel bad, she is the first to help. I also love her apple pie, which she makes every Sunday. Cooking is her hobby. My father is a teacher His hobby is working in a little garden in front of our house. As my future profession is agronomist, I help him look after the trees and flowers. My younger brother Nick is not fond of nature. He spends ail his free time with his computer. We are both students. We study at the same university. We are all different, but when we gather together on Sundays, we can talk for hours. We discuss our family needs and plans for the future. I think we are a united and friendly family!";
            text = text.Replace(".", String.Empty).Replace(",", String.Empty).Replace("-", String.Empty).Replace("!", String.Empty);
            var stringArray = text.Split(" ");

            Console.WriteLine("\nText");
            var wordCount = arrayOperation.FindWordCount(stringArray);
            Console.WriteLine(text);
            Console.WriteLine("\nWord Count:");
            foreach (var element in wordCount)
            {
                Console.WriteLine($"Word: {element.word}, Count: {element.count} ");
            }

        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Fills array by random numbers
        /// </summary>
        /// <returns>Returns array with random numbers</returns>
        private static int[] FillArrayByRandomNumbers ()
        {
            Random random = new Random();
            var array = new int[random.Next(1, 1001)];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
            }
            return array;
        }

        /// <summary>
        /// Writes <paramref name="array"/> to the console
        /// </summary>
        /// <param name="array">Array</param>
        private static void IntArrayOutput (int [] array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }
        #endregion
    }
}
