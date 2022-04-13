using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._0_CalculateBankSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 7.0: Calculate Bank Savings");
            Console.WriteLine("*****************************************************");

            /*
             * Solution using Math.Pow(,):
             */

            //  VAR
            double initialInvestment;
            double amount;
            double bankInterestRate;
            int monthlyApplicationPeriod;

            //  Data
            initialInvestment = 1000.00;
            bankInterestRate = 0.36;
            monthlyApplicationPeriod = 12;

            //  Calculating Compound Interest
            amount = initialInvestment * (Math.Pow((1 + bankInterestRate / 100), monthlyApplicationPeriod));
            Console.WriteLine("Your amount will be: R$ " + amount + " in the end of the period!");
            Console.WriteLine("*****************************************************");

            /*
             * Solution using While
             */

            //  VAR
            int monthlyCounter;

            //  Data
            monthlyCounter = 1;

            //  Calculating Compound Interest
            while (monthlyCounter <= 12)
            {
                initialInvestment = initialInvestment + (initialInvestment * (bankInterestRate / 100));
                Console.WriteLine($"After {monthlyCounter} month(s), your amount will be: R$ " + initialInvestment);

                monthlyCounter++;
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
