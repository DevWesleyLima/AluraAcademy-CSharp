using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 6.0: Scope");
            Console.WriteLine("*****************************************************");

            //  VAR
            int age = 18;
            bool companionCheck = true;
            string additionalMessage;

            if (companionCheck == true)
            {
                additionalMessage = "John has a companion!";
            }
            else
            {
                additionalMessage = "John doesn't have a companion!";
            }

            if (age >= 18 || companionCheck == true)
            {
                Console.WriteLine("You can come in!!!");
                Console.WriteLine(additionalMessage);
            }
            else
            {
                Console.WriteLine("You can't come in !!!");
                Console.WriteLine(additionalMessage);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
