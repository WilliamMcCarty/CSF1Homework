using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class InterestCalc
    {
        static void Main(string[] args)
        {
            decimal balance;
            decimal interestRate;
            decimal years;

            Console.Title = "-==== INTEREST CALCULATOR ====-";

            Console.WriteLine("Please enter your beginning balance (decimals are OK).\n");
            balance = decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter your interest rate percentage (without the %).\n");
            interestRate = decimal.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter the number of years for your loan.\n");
            years = decimal.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < years; i++)
            {
                balance += balance * (interestRate / 100);
            }

            Console.WriteLine($"The amount you will have in {years} year{(Convert.ToInt32(years) == 1 ? "" : "s")} is {balance:c}\n");
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
