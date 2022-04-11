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
            HashtableListOperation hashtableListOperation = new HashtableListOperation();
            DictionaryReferenceTypeListOperation dictionaryReferenceTypeListOperetion = new DictionaryReferenceTypeListOperation();
            DictionaryValueTypeListOperation dictionaryValueTypeListOperation = new DictionaryValueTypeListOperation();

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
            dictionaryValueTypeListOperation.FillingWithTenThousand();
            Console.WriteLine("Dictionary value type finds first index");
            dictionaryValueTypeListOperation.Find();
            Console.WriteLine("Dictionary value type finds all indexes");
            dictionaryValueTypeListOperation.FindAll();
            Console.WriteLine("Dictionary value type add element");
            dictionaryValueTypeListOperation.ListAdd();
            Console.WriteLine("Dictionary value type remove element");
            dictionaryValueTypeListOperation.Remove();
            Console.WriteLine("");

            Console.WriteLine("Dictionary reference type");
            Console.WriteLine("____________________________________");
            dictionaryReferenceTypeListOperetion.FillingWithTenThousand();
            Console.WriteLine("Dictionary reference type finds first index");
            dictionaryReferenceTypeListOperetion.Find();
            Console.WriteLine("Dictionary reference type finds all indexes");
            dictionaryReferenceTypeListOperetion.FindAll();
            Console.WriteLine("Dictionary reference type add element");
            dictionaryReferenceTypeListOperetion.ListAdd();
            Console.WriteLine("Dictionary reference type remove element");
            dictionaryReferenceTypeListOperetion.Remove();
            Console.WriteLine("");          
        }
    }
}
