using System;

namespace FirstTask
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
            Console.WriteLine("Decimal array");
            DecimalListOperation decimalListOperation = new DecimalListOperation();
            decimalListOperation.FillingWithTenThousand();
            decimalListOperation.FillingInOneThousandTwentyFour();
            decimalListOperation.ListAddRange();
            decimalListOperation.Find();
            decimalListOperation.Remove();
            Console.WriteLine("");
            Console.WriteLine("Exception array");
            ExceptionListOperation exceptionListOperation = new ExceptionListOperation();
            exceptionListOperation.FillingWithTenThousand();
            exceptionListOperation.FillingInOneThousandTwentyFour();
            exceptionListOperation.ListAddRange();  
            exceptionListOperation.Find();
            exceptionListOperation.Remove();
            Console.WriteLine("");
            Console.WriteLine("ArrayList");
            ArrayListOperation arrayListOperation = new ArrayListOperation();
            arrayListOperation.FillingWithTenThousand();
            arrayListOperation.FillingInOneThousandTwentyFour();
            arrayListOperation.ListAddRange();
            arrayListOperation.Find();
            arrayListOperation.Remove();

            // TODO: change compare tables view
            Console.WriteLine("ArrayList and List<decimal>");
            arrayListOperation.FillingWithTenThousand();
            decimalListOperation.FillingWithTenThousand();
            Console.WriteLine("ArrayList and List<Exception>");
            arrayListOperation.FillingWithTenThousand();
            // TODO: there is no method to fill List<Exception>
            Console.WriteLine("Pack/Unpack in ArrayList and List<decimal>");
            // TODO: there is no method to unpack ArrayList objects
            decimalListOperation.ProcessValues();
            Console.WriteLine("Insert n-elements in ArrayList and List<decimal>");
            decimalListOperation.ListAddRange();
            arrayListOperation.ListAddRange();
            Console.WriteLine("Insert n-elements in ArrayList and List<Exception>");

            Console.WriteLine("Delete 1 element in ArrayList and List<decimal>");
            decimalListOperation.Remove();
            arrayListOperation.Remove();
            Console.WriteLine("Delete 1 element in ArrayList and List<Exception>");

            Console.WriteLine("Find 1 element in ArrayList and List<decimal>");
            decimalListOperation.Find();
            arrayListOperation.Find();
            Console.WriteLine("Find 1 element in ArrayList and List<Exception>");
        }
    }
}
