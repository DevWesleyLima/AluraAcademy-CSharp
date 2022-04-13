using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0_VariableAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 4.0: Variable Assignments");
            Console.WriteLine("*****************************************************");

            //  VAR
            int age;
            int gustavoAge;

            age = 32;
            gustavoAge = age;

            Console.WriteLine("How old is Gustavo??");
            Console.WriteLine("A: He is " + gustavoAge + " years old");

            Console.WriteLine();
            age = 33;
            gustavoAge = age;

            Console.WriteLine("How old is Gustavo now??");
            Console.WriteLine("A: He is " + gustavoAge + " years old");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
