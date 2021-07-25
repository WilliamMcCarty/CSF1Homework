using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool continueProgram = false;
            string tempType;
            decimal userCelsius;
            decimal fahrenheitResult;
            decimal userFahrenheit;
            decimal celsiusResult;

            Console.Title = "-==== TEMPERATURE CONVERTER ====-";

            do
            {
                Console.WriteLine("Which system of measurement would you like to convert?\n" +
                    "Celsius (C)\n" +
                    "Fahrenheit (F)\n");
                tempType = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (tempType)
                {
                    case "CELSIUS":
                    case "C":
                        Console.WriteLine("Please enter a numeric temperature value in Celsius to convert: ");
                        userCelsius = decimal.Parse(Console.ReadLine());
                        fahrenheitResult = userCelsius * (9.0m / 5.0m) + 32;
                        Console.Clear();
                        Console.WriteLine($"The Celsius value of {userCelsius}\x00B0 converted to Fahrenheit is {fahrenheitResult}\x00B0\n");
                        Console.WriteLine("Would you like to do another temperature conversion? Y/N\n");
                        continueProgram = Console.ReadLine().ToUpper() == "Y";
                        Console.Clear();
                        break;
                    case "FAHRENHEIT":
                    case "F":
                        Console.WriteLine("Please enter a numeric temperature value in Fahrenheit to convert: ");
                        userFahrenheit = decimal.Parse(Console.ReadLine());
                        celsiusResult = (userFahrenheit - 32) / (9.0m / 5.0m);
                        Console.Clear();
                        Console.WriteLine($"The Fahrenheit value of {userFahrenheit}\x00B0 converted to Celsius is {celsiusResult}\x00B0\n");
                        Console.WriteLine("Would you like to do another temperature conversion? Y/N\n");
                        continueProgram = Console.ReadLine().ToUpper() == "Y";
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid system of measurement.\nYou must choose between Celsius (C) or Fahrenheit (F)\n");
                        continueProgram = true;
                        break;
                }
            } while (continueProgram);

            Console.WriteLine("Leaving The Program.\n");

        }//END MAIN
    }//END CLASS
}//END NAMESPACE
