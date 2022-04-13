using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 5.0: Conditional Statements");
            Console.WriteLine("*****************************************************");

            /*
             *  Tips!!!
             *  Formating Document Shortcut: Ctrl + D
             *  or click in Menu > Edit > Advanced > Format Document
             */

            //  VAR
            string name;
            string typedName;
            int age;
            string companionQuestion;
            int companionAgeQuestion;

            Console.WriteLine("What is your Name?");
            typedName = Console.ReadLine();
            name = typedName.Substring(0, 1).ToUpper() + typedName.Remove(0, 1).ToLower();
            Console.WriteLine();
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome " + name + ", you can come in!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("I have noticed you are underaged...");
                Console.WriteLine("Do you have a companion?? (yes or no)");
                companionQuestion = Console.ReadLine();

                if (companionQuestion.Substring(0, 1).ToLower() == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("How old is your companion?");
                    companionAgeQuestion = int.Parse(Console.ReadLine());

                    if (companionAgeQuestion >= 18)
                    {
                        Console.WriteLine();
                        Console.WriteLine(name + ", you are underaged...");
                        Console.WriteLine("But your companion is not!!!");
                        Console.WriteLine("Welcome, you can come in!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry, you both are underaged!!!");
                        Console.WriteLine("You can't come in!");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(name + ", you are underaged and you don't have a companion!!!");
                    Console.WriteLine("Sorry, you can't come in!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
