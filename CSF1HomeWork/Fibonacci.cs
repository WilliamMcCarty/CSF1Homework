using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int userNumber;
            int currentNumber = 0;
            int previousNumber = 0;
            int nextNumber = 0;

            Console.Title = "-==== FIBONACCI ====-";

            Console.WriteLine("Pease input a whole number between 1 & 100000 for a starting point and ending point.");
            userNumber = int.Parse(Console.ReadLine());

            Console.Clear();

            while (currentNumber < userNumber)
            {
                if (currentNumber == 0)
                {
                    currentNumber++;
                    Console.Write("{0}, {1}, ", previousNumber, currentNumber);
                }
                else
                {
                    nextNumber = currentNumber + previousNumber;

                    if ((currentNumber + previousNumber) < userNumber)
                    {
                        Console.Write("{0}, ", nextNumber);
                    }
                    else
                    {
                        Console.Write("{0} ", nextNumber);
                    }

                    previousNumber = currentNumber;
                    currentNumber = nextNumber;
                }
            }

            Console.WriteLine("\n");

        }//END MAIN
    }//END CLASS
}//END NAMESPACE
