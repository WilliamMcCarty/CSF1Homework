using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            Console.Title = "-==== FRUITLOOP1 ====-";

            string[] fruits = { "Grapefruit", "Grapes", "Apple", "Mango", "Blueberries", "Apricot" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
