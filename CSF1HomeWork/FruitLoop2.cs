using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomeWork
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.Title = "-==== FRUIT LOOP TWO ====-";

            string[] fruits = { "Grapefruit", "Grapes", "Apple", "Mango", "Blueberries", "Apricot" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);

                for (int z = -1; z < i; z++)
                {
                    Console.Write(".");
                }

                Console.Write("\n");
            }
        }//END MAIN
    }//END CLASS
}//END NAMESPACE
