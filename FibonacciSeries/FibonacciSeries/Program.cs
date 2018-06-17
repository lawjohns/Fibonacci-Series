using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {

        static int maxLength = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of places to calculate: ");

            maxLength = GetUserInput() - 1;

            FibonacciRecursive(0, 0, 0);

            Console.Read();
        }

        private static int GetUserInput()
        {
            string userInput = Console.ReadLine();

            int result;

            int.TryParse(userInput, out result);

            if (result >= 2) { return result; }
            else { return 2;  }
        }

        private static void FibonacciRecursive(long num1, long num2, int length)
        {
            long result = num1 + num2;
            Console.Write("{0} ", result);

            if (length < maxLength)
            {
                if ( num1 == 0 && num2 == 0 ) {  num2 = 1; }
                else if ( num1 == 1 && num2 == 0 ) { num2 = 0; }

                FibonacciRecursive(num2, result, ++length);
            }
        }
    }
}
