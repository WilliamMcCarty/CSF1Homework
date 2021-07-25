using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class GradesLoop
    {
        static void Main(string[] args)
        {
            string enteredScore;
            string allScores = "";

            Console.Title = "-==== GRADES LOOP ====-";

            do
            {
                Console.WriteLine("Please enter a score between 0 & 100.  A negative number will display the all the scores.\n");
                enteredScore = Console.ReadLine();

                Console.Clear();

                if (int.Parse(enteredScore) >= 0)
                {
                    allScores += $"{enteredScore}\n";
                }

            } while (int.Parse(enteredScore) >= 0);

            Console.WriteLine("All Scores\n{0}", allScores);
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
