using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class Powers
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_POWERS = 50;
            bool isOneRan = false;
            long longWayAnswer = 2;
            long longWayPower = 2;

            Console.Title = "-==== POWERS ====-";

            for (int i = 1; i <= NUMBER_OF_POWERS; i++)
            {
                for (int z = 1; z <= i; z++)
                {
                    if (z == 1 && !isOneRan)
                    {
                        isOneRan = true;
                    }
                    else
                    {
                        longWayAnswer *= longWayPower;
                    }
                }

                long answer = (long)Math.Pow(2, i);
                Console.WriteLine("{0}", longWayAnswer);
                longWayAnswer = 2;
            }

        }//END MAIN
    }//END CLASS
}//END NAMESPACE
