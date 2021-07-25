using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class FizzBuz
    {
        static void Main(string[] args)
        {
            Console.Title = "-==== CSF1 FIZZ BUZZ HOMEWORK ====-";

            Console.WriteLine("Please enter a whole number between 1 and 100.");
            int userNumber = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        } //END MAIN
    } //END CLASS
} //END NAMESPACE
