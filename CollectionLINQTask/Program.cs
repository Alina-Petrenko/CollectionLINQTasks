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
        }
    }
}
