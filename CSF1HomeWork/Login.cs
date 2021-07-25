using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.Title = "-==== LOGIN ====-";

            bool programRun;

            int userNameTrys = 3;
            int passwordTrys = 3;

            const string USER_NAME = "KATIE";
            const string USER_PASSWORD = "KITE";

            do
            {
                programRun = true;
                Console.WriteLine("Please log in with the username for your account.");
                Console.WriteLine("Enter your username:\tExample: 'katie'\n");
                string userName = Console.ReadLine().ToUpper();
                Console.Clear();

                if (userName == USER_NAME)
                {
                    do
                    {
                        Console.WriteLine("To continue, please supply the password for your account.");
                        Console.WriteLine("Enter your password:\tExample: 'kite'\n");
                        string password = Console.ReadLine().ToUpper();
                        Console.Clear();

                        if (password == USER_PASSWORD)
                        {
                            Console.WriteLine("Account Access Approved.\n");

                            programRun = false;
                        }
                        else
                        {
                            passwordTrys--;

                            if (passwordTrys > 0)
                            {
                                Console.WriteLine("Incorrect Password. Access denied.\n" +
                                                  $"You have {passwordTrys} attempt{(passwordTrys == 1 ? "" : "s")} remaining.\n");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect User Name. Access Denied.\n" +
                                                  "Your account is now locked, please contact your account rep.\n");

                                programRun = false;
                            }
                        }
                    } while (programRun && passwordTrys > 0);
                }
                else
                {
                    userNameTrys--;

                    if (userNameTrys > 0)
                    {
                        Console.WriteLine("Incorrect User Name. Access Denied.\n" +
                                         $"You have {userNameTrys} attempt{(userNameTrys == 1 ? "" : "s")} remaining.\n");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect User Name. Access Denied.\n" +
                                          "Your account is now locked, please contact your account rep.\n");

                        programRun = false;
                    }
                }
            } while (programRun);
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
