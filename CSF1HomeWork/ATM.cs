using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class ATM
    {
        static void Main(string[] args)
        {
            int accountNumber = 987654;
            int loginTrys = 1;
            int allowedLoginTrys = 5;
            int pinNumber = 6832;
            int userPinNumber;
            bool cycle = true;
            string menuDeposit = "Press D For A Deposit\n";
            string menuWithDrawl = "Press W For A Withdrawl\n";
            string menuBalance = "Press B For Balance\n";
            string menuExit = "Press E To Exit\n";
            bool exitMenu = false;
            decimal accountBalance = 0;
            decimal deposit;
            decimal withDrawl;

            Console.Beep();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "-==== ATM MACHINE ====-";

            do
            {
                Console.Clear();
                Console.Write("\nEnter Your Account Number: ");
                accountNumber = int.Parse(Console.ReadLine());

                switch (accountNumber)
                {
                    case 987654:
                        do
                        {
                            Console.Clear();
                            Console.Write("\nEnter Your Pin Number: ");
                            userPinNumber = int.Parse(Console.ReadLine());
                        } while (pinNumber != userPinNumber);

                        do
                        {
                            Console.Clear();
                            Console.Write($"Your current balance is: {accountBalance:c}\n\n");
                            Console.Write(menuDeposit + menuWithDrawl + menuBalance + menuExit);
                            ConsoleKey menuSelected = Console.ReadKey(true).Key;

                            switch (menuSelected)
                            {
                                case ConsoleKey.D:
                                    Console.Clear();
                                    Console.Write("How Much Would You Like To Deposit: ");
                                    deposit = decimal.Parse(Console.ReadLine());
                                    accountBalance += deposit;
                                    Console.Clear();
                                    Console.WriteLine($"{deposit:c} has been deposited into account number: {accountNumber}");
                                    Console.WriteLine($"Your current balance is: {accountBalance:c}");
                                    Console.WriteLine("Press Enter To Continue");
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.W:
                                    Console.Clear();
                                    Console.Write("How Much Would You Like To Withdraw: ");
                                    withDrawl = decimal.Parse(Console.ReadLine());
                                    accountBalance -= withDrawl;
                                    Console.Clear();
                                    Console.WriteLine($"{withDrawl:c} has been withdrawn from account number: {accountNumber}");
                                    Console.WriteLine($"Your current balance is: {accountBalance:c}");
                                    Console.WriteLine("Press Enter To Continue");
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.B:
                                    Console.Clear();
                                    Console.WriteLine($"Your current balance is: {accountBalance:c}");
                                    Console.WriteLine("Press Enter To Continue");
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.E:
                                    exitMenu = true;
                                    break;
                                default:
                                    break;
                            }

                        } while (!exitMenu);


                        cycle = false;
                        break;

                    default:
                        Console.Clear();
                        if (loginTrys >= allowedLoginTrys)
                        {
                            Console.Beep();
                            Console.WriteLine("You have exceeded 5 trys, you are now locked out.");
                            Console.ReadLine();
                            cycle = false;
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine($"Invalid account number you have {allowedLoginTrys - loginTrys} left.");
                            Console.ReadLine();
                        }
                        loginTrys++;

                        break;
                }
            } while (cycle);

            if (loginTrys < allowedLoginTrys)
            {
                Console.Clear();
                Console.WriteLine("Thank you for your business.");
                Console.ReadLine();
            }

        }//END MAIN
    }//END CLASS
}//END NAMESPACE
