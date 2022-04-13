using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_CreatingVariablesFloatingPointTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 1.1: Creating Variables Floating Point Types");
            Console.WriteLine("**********************************************************");

            //  VAR
            double monthlySalary;
            double age;

            monthlySalary = 1200.70;
            Console.WriteLine(monthlySalary);

            //  if both int values
            age = 5 / 3;
            Console.WriteLine("Age (5 / 3): " + age + " anos!");

            //  if one of them is float/double
            age = 15 / 2.0;
            Console.WriteLine("Age (5 / 2.0): " + age + " anos!");

            age = 5.0 / 3;
            Console.WriteLine("Age (5.0 / 3): " + age + " anos!");

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
