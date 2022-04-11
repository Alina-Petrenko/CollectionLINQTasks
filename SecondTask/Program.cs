using System;

namespace SecondTask
{
    /// <summary>
    /// Starts the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Prints the results of method calls
        /// </summary>
        static void Main()
        {
            // TODO: use var in every place where it possible.
            var hashtableListOperation = new HashtableListOperation();
            var referenceTypeListOperation = new DictionaryReferenceTypeListOperation();
            var valueTypeListOperation = new DictionaryValueTypeListOperation();

            Console.WriteLine("Hastable reference type");
            Console.WriteLine("____________________________________");
            hashtableListOperation.FillingWithTenThousand();
            Console.WriteLine("Hastable reference type finds first index");
            hashtableListOperation.Find();
            Console.WriteLine("Hastable reference type finds all indexes");
            hashtableListOperation.FindAll();
            Console.WriteLine("Hastable reference type add element");
            hashtableListOperation.ListAdd();
            Console.WriteLine("Hastable reference type remove element");
            hashtableListOperation.Remove();          
            Console.WriteLine("");
            hashtableListOperation.HashTableList.Clear();

            Console.WriteLine("Hastable value type");
            Console.WriteLine("____________________________________");
            hashtableListOperation.FillingWithTenThousand(false);
            Console.WriteLine("Hastable value type finds first index");
            hashtableListOperation.Find(false);
            Console.WriteLine("Hastable value type finds all indexes");
            hashtableListOperation.FindAll(false);
            Console.WriteLine("Hastable value type add element");
            hashtableListOperation.ListAdd(false);
            Console.WriteLine("Hastable value type remove element");
            hashtableListOperation.Remove();
            Console.WriteLine("");

            Console.WriteLine("Dictionary value type");
            Console.WriteLine("____________________________________");
            valueTypeListOperation.FillingWithTenThousand();
            Console.WriteLine("Dictionary value type finds first index");
            valueTypeListOperation.Find();
            Console.WriteLine("Dictionary value type finds all indexes");
            valueTypeListOperation.FindAll();
            Console.WriteLine("Dictionary value type add element");
            valueTypeListOperation.ListAdd();
            Console.WriteLine("Dictionary value type remove element");
            valueTypeListOperation.Remove();
            Console.WriteLine("");

            Console.WriteLine("Dictionary reference type");
            Console.WriteLine("____________________________________");
            referenceTypeListOperation.FillingWithTenThousand();
            Console.WriteLine("Dictionary reference type finds first index");
            referenceTypeListOperation.Find();
            Console.WriteLine("Dictionary reference type finds all indexes");
            referenceTypeListOperation.FindAll();
            Console.WriteLine("Dictionary reference type add element");
            referenceTypeListOperation.ListAdd();
            Console.WriteLine("Dictionary reference type remove element");
            referenceTypeListOperation.Remove();
            Console.WriteLine("");          
        }
    }
}
