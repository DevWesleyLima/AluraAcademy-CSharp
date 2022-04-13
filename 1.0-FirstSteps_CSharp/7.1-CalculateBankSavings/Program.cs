using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_CalculateBankSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 7.1: Calculate Bank Savings");
            Console.WriteLine("*****************************************************");

            //  VAR
            double initialInvestment;
            double bankInterestRate;
            int monthlyCounter;

            //  Data
            initialInvestment = 1000.00;
            bankInterestRate = 0.36;

            //  Calculating Compound Interest
            for (monthlyCounter = 1; monthlyCounter <= 12; monthlyCounter++)
            {
                initialInvestment *= 1 + (bankInterestRate / 100);
                Console.WriteLine($"After {monthlyCounter} month(s), your amount will be: R$ " + initialInvestment);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
