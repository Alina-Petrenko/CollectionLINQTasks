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
            DecimalListOperation decimalListOperation = new DecimalListOperation();
            ExceptionListOperation exceptionListOperation = new ExceptionListOperation();
            ArrayListOperation arrayListOperation = new ArrayListOperation();

            Console.WriteLine("ArrayList and List<decimal> with 10000 values");
            decimalListOperation.FillingWithTenThousand();
            arrayListOperation.FillingWithTenThousand(false);

            Console.WriteLine("");
            Console.WriteLine("ArrayList and List<decimal> with 1024 values");
            decimalListOperation.FillingInOneThousandTwentyFour();
            arrayListOperation.FillingInOneThousandTwentyFour(false);

            Console.WriteLine("");
            Console.WriteLine("ArrayList and List<Exception> with 10000 values");
            arrayListOperation.FillingWithTenThousand();
            exceptionListOperation.FillingWithTenThousand();
            Console.WriteLine("");
            Console.WriteLine("ArrayList and List<Exception> with 1024 values");
            arrayListOperation.FillingInOneThousandTwentyFour();
            exceptionListOperation.FillingInOneThousandTwentyFour();
            Console.WriteLine("");
            Console.WriteLine("Pack/Unpack in ArrayList and List<decimal>");
            arrayListOperation.ProcessValues();
            decimalListOperation.ProcessValues();
            Console.WriteLine("");
            Console.WriteLine("Insert n-elements in ArrayList and List<decimal>");
            decimalListOperation.ListAddRange(300);
            arrayListOperation.ListAddRange(300);
            Console.WriteLine("");
            Console.WriteLine("Insert n-elements in ArrayList and List<Exception>");
            exceptionListOperation.ListAddRange(300);
            arrayListOperation.ListAddRange(300);
            Console.WriteLine("");
            Console.WriteLine("Delete 1 element in ArrayList and List<decimal>");
            decimalListOperation.Remove();
            arrayListOperation.Remove();
            Console.WriteLine("");
            Console.WriteLine("Delete 1 element in ArrayList and List<Exception>");
            exceptionListOperation.Remove();
            arrayListOperation.Remove();
            Console.WriteLine("");
            Console.WriteLine("Find 1 element in ArrayList and List<decimal>");
            decimalListOperation.Find();
            arrayListOperation.Find();
            Console.WriteLine("");
            Console.WriteLine("Find 1 element in ArrayList and List<Exception>");
            exceptionListOperation.Find();
            arrayListOperation.Find();
        }
    }
}
