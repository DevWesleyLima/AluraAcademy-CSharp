using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._0_CreatingVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 1.0: Creating Variables");
            Console.WriteLine("*************************************");

            //  VAR
            DateTime birthDate;
            DateTime todayDate;
            int age;

            Console.WriteLine("What is your birth date?? [dd/MM/yyy]");
            birthDate = DateTime.Parse(Console.ReadLine());

            todayDate = DateTime.Now;

            if (todayDate.Month >= birthDate.Month && todayDate.Day >= birthDate.Day)
            {
                age = todayDate.Year - birthDate.Year;
            }
            else
            {
                age = todayDate.Year - birthDate.Year - 1;
            }

            Console.WriteLine();
            Console.WriteLine("You are " + age + " years old!");

            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
