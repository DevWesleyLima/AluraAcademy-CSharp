using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0_ChainingForBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 8.0: Chaining For Break");
            Console.WriteLine("*****************************************************");

            /*
             * Break Method
             */

            //  1st Example
            for (int countLine = 0; countLine < 10; countLine++)
            {
                for (int countColumn = 0; countColumn < 10; countColumn++)
                {
                    Console.Write("*");
                    if (countColumn >= countLine)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }

            //  2nd Example
            for (int countLine = 0; countLine < 10; countLine++)
            {
                for (int countColumn = 0; countColumn < countLine; countColumn++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
