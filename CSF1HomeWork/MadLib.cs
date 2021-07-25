using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.Title = "-==== MAD LIB ====-";

            Console.WriteLine("\nPlease enter some information below to do this Mad Lib.  Unless otherwise specified, verbs should be in standard present tense (i.e. 'swim' or 'run').  Adverbs are words modifying verbs (like 'soon', or often ending in 'ly', like 'swiftly').  Adjectives are words that describe nouns (like 'green' or 'descriptive').");

            Console.WriteLine("\nNoun:");
            string noun = Console.ReadLine();

            Console.WriteLine("\nVerb:");
            string verb = Console.ReadLine();

            Console.WriteLine("\nAdjective:");
            string adjective = Console.ReadLine();

            Console.WriteLine("\nNoun (plural}:");
            string noun2 = Console.ReadLine();

            Console.WriteLine("\nVerb ending in '-ing':");
            string verb2 = Console.ReadLine();

            Console.WriteLine("\nAdjective:");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("\nAdverb:");
            string adverb = Console.ReadLine();

            Console.WriteLine("\nExclamation:");
            string exclamation = Console.ReadLine();

            Console.WriteLine("\nCity:");
            string city = Console.ReadLine();

            Console.WriteLine("\nA Time Of Day:");
            string time = Console.ReadLine();

            Console.WriteLine("\nHope the story is funny and make sense!");
            Console.WriteLine($"One day there was a {noun} who preferred to {verb}.  On another day they preferred to go by the {adjective} {noun2}. When going by it, it came to mind to start {verb2}.  When there they notice a {adjective2} six legged frog.  It came to mind to {adverb} and then run but instead they made friends.  When they went to pick it up, it \"{exclamation}\" and jumped behind big rock.  After leaving they came upon {city} and notice the time was {time} and decided to head back home.");
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
